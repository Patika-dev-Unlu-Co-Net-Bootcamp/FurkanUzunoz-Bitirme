using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema ;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Bitirme.Entity.Entities
{
    public class Offers
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OfferID { get; set; }
        [Required]
        public int OfferUserID { get; set; }
        [Required]
        public int ProductID { get; set; }
        public Product product { get; set; }
        [Required]
        public int OfferPrice { get; set; }

        public bool isOfferActive { get; set; } = true;
    }
}
