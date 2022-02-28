using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Interface;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces.Concrete
{
    public class UsersRepository : Repository<Users>, IUsers
    {
        private readonly DbContextOperation _dbContext;
        public UsersRepository(DbContextOperation dbcontext) : base(dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<Users> GetByMail(string email)
        {
            var result = await GetAll() ;
            return  result.Where(e => e.Email == email).FirstOrDefault();
            
        }

        public async Task AddFailedlogin(Users entity)
        {
            
            entity.FiledLogin = entity.FiledLogin+1 ;
            await Task.Run(() => { _dbContext.Users.Update(entity); }); 
        }

        public async Task<bool> UsersState(string email)
        {
            var result = await GetAll();
            var entity=result.Where(e => e.Email == email).FirstOrDefault();

            return entity.state;
        }
    }
}
