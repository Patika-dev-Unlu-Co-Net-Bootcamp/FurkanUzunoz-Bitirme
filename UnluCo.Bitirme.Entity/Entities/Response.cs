using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Bitirme.Entity.Entities
{
    public class Response
    {
        public string Message { get; set; }
        public int State { get; set; }
        public int StatusCode { get; set; } = 500;
    }
}
