using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Bitirme.DataAcces.Dtoes
{
    public class UsersDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Password2 { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string Gsm { get; set; }
        [Required]
        public bool Gender { get; set; }
    }
}
