using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces.Dtoes
{
    public class ProductDto
    {
        public int UserID { get; set; }
        [MaxLength(100)]
        [Required]
        public string ProductName { get; set; }
        [MaxLength(500)]
        [Required]
        public string ProductDescription { get; set; }

        [Required]
        public string CategoryName { get; set; }
        
        [Required]
        public string ColorName { get; set; }
        
        [Required]
        public string BrandName { get; set; }
        
        [Required]
        public string UseStatusName { get; set; }
        [Required]
        public IFormFile file { get; set; }
        [Required]
        public Int32 Price { get; set; }
        public bool IsOfferable { get; set; } = false;

    }
}
