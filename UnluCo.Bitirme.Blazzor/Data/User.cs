using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Bitirme.Blazzor.Data
{
    public class User : IDPass
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string Gsm { get; set; }
        [Required]
        public bool Gender { get; set; }

        public bool state { get; set; } = true;

        public int FiledLogin { get; set; } = 0;

        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

    }
}
