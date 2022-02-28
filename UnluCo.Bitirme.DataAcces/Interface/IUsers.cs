using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Concrete;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces.Interface
{
    public interface IUsers :IRepository<Users> 
    {
       Task<Users> GetByMail(string email);

        Task AddFailedlogin(Users entity);
        Task<bool> UsersState(string email);
    }
}
