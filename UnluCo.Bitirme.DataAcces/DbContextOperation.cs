using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces
{
    public class DbContextOperation :DbContext
    {
        public DbContextOperation(DbContextOptions<DbContextOperation> options) : base(options) { }
       
        public DbSet<Users> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Offers> Offers { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<UseStatus> UseStatuses { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=UnluCoBitirme;Trusted_Connection=True;MultipleActiveResultSets=true");
        }*/
    }
}
