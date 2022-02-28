using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.Business.Interface;
using UnluCo.Bitirme.Business.Rules.Interface;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.DataAcces.Interface;
using UnluCo.Bitirme.Entity.Entities;
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace UnluCo.Bitirme.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUsers _user;
        private readonly IMapper _mapper;
        private readonly IRulesForSignUp _Rules;
        private readonly IConfiguration _config;
        private readonly IEmailSender _mail;
        public UserService(IUsers User ,IMapper mapper, IRulesForSignUp Rules,IConfiguration configuration
            ,IEmailSender mail)
        {
            _user = User;
            _mapper = mapper;
            _Rules = Rules;
            _config = configuration;
            _mail = mail;
        }
        public string key { get; set; } = "dsgsdg^'!234SFs" ;
        public string ConvertToMd5(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] dizi = Encoding.UTF8.GetBytes(str+key);

            dizi = md5.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        public async Task<Response> Create(UsersDto model)
        {
            try
            {
                if (_Rules.handle(model))
                {
                    var model2 = _mapper.Map<Users>(model);
                    model2.Password=ConvertToMd5(model2.Password);
                    await _mail.WelcomeMail(model2.Email);
                    await _user.Create(model2);
                    
                    return new Response { Message = "Başarı ile kayıt yapıldı.", State = 1, StatusCode = 200 };
                }
                else
                {
                    return new Response { Message = "Girmiş olduğunuz kayıtlar kurallara uymuyor tekrar giriniz", State = 0, StatusCode = 401 };
                }

            }
            catch (Exception e)
            {

                return new Response { Message = e.Message, State = 0, StatusCode = 500 };
            }
            
            
            
        }


        public int sayac = 0;
        public async Task<ResponseToken> GetByMail(IDPass model)
        {
            var Token = new Token();
            if (_user.UsersState(model.Email).Result)
            {
                
                // buradaki sayacı sil veri tabanına sayac koy users entitysine ekle her hatalı girişte onu artır sonra orada bir trigger yaz eğer 
                //oradaki sayac 3 'e gelirse pasif duruma getir.
                
                var result = await _user.GetByMail(model.Email);
                if (result is not null)
                {
                    var result2 = _mapper.Map<IDPass>(result);
                    if (ConvertToMd5(model.Password) == result2.Password)
                    {
                        Token = await BackToToken(model);
                        return new ResponseToken { token = Token, statuscode = 200 };                        
                        
                    }

                    await _user.AddFailedlogin(result);
                    return new ResponseToken { token = Token, statuscode = 401 };

                }
                await _mail.SendEmailAsync(model.Email, "Bloke", "Hesabınız Yanlış girişten dolayı bloke edilmiştir.");
                return new ResponseToken { token = Token, statuscode = 401 };
            }


            return new ResponseToken { token = Token, statuscode = 500 };

            //mapplernmiş doncek 

        }

        public async Task<Token> BackToToken(IDPass model)
        {
            Token tokenmodel = new Token();
            await Task.Run(() =>
            {

                SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Token:SignKey"]));
                SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                tokenmodel.Expration = DateTime.Now.AddHours(2);

                JwtSecurityToken security = new JwtSecurityToken
                (
                    issuer: _config["Token:Issuer"],
                    audience: _config["Token:Audience"],
                    expires: tokenmodel.Expration,
                    notBefore: DateTime.Now,
                    signingCredentials: credentials
                );
                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                tokenmodel.AccessToken = handler.WriteToken(security);
                tokenmodel.RefreshToken = CreateRefreshToken();

            });
            
            return tokenmodel;
        }
        public string CreateRefreshToken()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
