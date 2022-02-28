using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.DataAcces.Interface;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces.Concrete
{
    public class CategoryRepository :Repository<Category>, ICategory
    {
        private readonly DbContextOperation _dbContext;
        public CategoryRepository(DbContextOperation dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ProductsbycategoryDto>> GetProductByCategoryId(int id)
        {
            var query = new List<ProductsbycategoryDto>(); 
            try
            {
                await Task.Run(() =>
                {

                    query = (from categ in _dbContext.Categories
                                 join prod in _dbContext.Products
                                 on categ.CategoryID equals prod.CategoryID
                                 join brand in _dbContext.Brands
                                 on prod.BrandID equals brand.BrandID
                                 join color in _dbContext.Colors
                                 on prod.ColorID equals color.ColorID
                                 join Uses in _dbContext.UseStatuses
                                 on prod.UseStatusID equals Uses.UseStatusID
                                 where categ.CategoryID== id
                                 select new ProductsbycategoryDto
                                 {
                                     BrandName = brand.BrandName,
                                     CategoryName = categ.CategoryName,
                                     ColorName = color.ColorName,
                                     UseStatusName = Uses.UseStatusName,
                                     Price = prod.Price,
                                     ProductDescription = prod.ProductDescription,
                                     ProductName = prod.ProductName
                                 }).ToList();

                    return query;

                });
                return query ;
            }
            catch (Exception)
            {

                return new List<ProductsbycategoryDto>() ;
            }
             
        }

       
    }
}
