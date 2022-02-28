using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces.Dtoes
{
    public class TokenWithUser :Users
    {
        public string AccessToken { get; set; }
    }
}
