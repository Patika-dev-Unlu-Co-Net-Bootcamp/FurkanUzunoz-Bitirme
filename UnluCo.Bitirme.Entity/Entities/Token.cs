using System;

namespace UnluCo.Bitirme.Entity.Entities
{
    public class Token
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expration { get; set; } 
    }
}