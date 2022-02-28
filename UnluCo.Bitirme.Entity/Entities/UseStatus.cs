using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Bitirme.Entity.Entities
{
    public class UseStatus
    {
        [Key]
        public int UseStatusID { get; set; }

        public string UseStatusName { get; set; }
    }
}
