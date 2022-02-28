using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Bitirme.Entity.Entities
{
    public class Color
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ColorID { get; set; }

        public string ColorName { get; set; }
    }
}
