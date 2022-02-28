using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.Business.Interface;
using UnluCo.Bitirme.Business.Rules.Interface;
using UnluCo.Bitirme.DataAcces;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.Business.Rules.Concrete
{
    public class RulesForUsers : IRulesForSignUp
    {
        private readonly DbContextOperation _context;

        public RulesForUsers(DbContextOperation context)
        {
            _context = context;
        }
        public bool handle(UsersDto model)
        {
            if(isValidGsm(model) && isValidMail(model) && isValidPass(model) && isValidUserName(model))
            {
                return true;
            }
            return false;
        }

        public bool isValidGsm(UsersDto model)
        {
            if (model.Gsm.Length==10 && model.Gsm.Any(c=> char.IsDigit(c)))
            {
                return true;
            }
            return false;
        }

        public bool isValidMail(UsersDto model)
        {
            if (model.Email.Contains("@"))
            {
                var parca =model.Email.Split(".");
                if(parca[parca.Length-1]=="com")
                {
                    return true;
                }
            }
            return false;
        }

        public bool isValidPass(UsersDto model)
        {
            if (model.Password == model.Password2 && model.Password.Length>=8 && model.Password.Length<=20 && model.Password.Any(c=> char.IsUpper(c) || char.IsLower(c)|| char.IsDigit(c)))
            {
                return true;
            }
            return false;
        }

        public bool isValidUserName(UsersDto model)
        {
            if(_context.Set<Users>().Any(x=>x.Username==model.Username || x.Gsm==model.Gsm || x.Email == model.Email))
            {
                return false;
            }
            return true;
        }
    }
}
