using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces.Interface
{
    public interface IForSignUp
    {
        public Response Signup(Users model);
    }
}
