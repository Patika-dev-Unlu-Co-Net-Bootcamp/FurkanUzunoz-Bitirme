using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.Business.Interface
{
    public interface IUserService
    {
        Task<Response> Create(UsersDto model);

        Task<ResponseToken> GetByMail(IDPass model);

        Task<Token> BackToToken(IDPass model);
    }
}
