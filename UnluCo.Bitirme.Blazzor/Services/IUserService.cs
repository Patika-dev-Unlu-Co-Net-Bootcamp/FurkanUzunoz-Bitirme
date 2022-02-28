using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Bitirme.Blazzor.Data;

namespace UnluCo.Bitirme.Blazzor.Services
{
    public interface IUserService
    {
        public Task<User> LoginAsync(User user);
        public Task<User> RegisterUserAsync(User user);
        public Task<User> GetUserByAccessTokenAsync(string accessToken);

        public Task<Response> CreateAccount(User user);
        
    }
}
