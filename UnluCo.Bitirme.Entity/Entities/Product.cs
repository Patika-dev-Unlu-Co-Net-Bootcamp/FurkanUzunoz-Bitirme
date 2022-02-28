using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Bitirme.Entity.Entities
{
    public class Product
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [MaxLength(100)]
        [Required]
        public string ProductName { get; set; }
        [MaxLength(500)]
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public int UserID { get; set; }
        public Users Sign { get; set; }
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        [Required]
        public int ColorID { get; set; }
        public Color color { get; set; }
        [Required]
        public int BrandID { get; set; }
        public Brand brand { get; set; }
        [Required]
        public int UseStatusID { get; set; }
        public UseStatus UseStatus { get; set; }
        public byte[] Image { get; set; }
        [Required]
        public Int32 Price { get; set; }
        public bool IsOfferable { get; set; } = false;
        public bool IsSold { get; set; } = false;

    }

}
