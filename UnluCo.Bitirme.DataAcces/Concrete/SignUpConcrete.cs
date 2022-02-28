using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Interface;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces.Concrete
{
    public class SignUpConcrete : IForSignUp
    {
        public Response Signup(Users model)
        {
            return new Response { Message = "lala", State = 1 }; 
        }
    }
}
