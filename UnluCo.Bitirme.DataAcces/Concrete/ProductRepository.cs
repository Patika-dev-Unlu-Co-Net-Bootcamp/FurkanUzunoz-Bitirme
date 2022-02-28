using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.DataAcces.Interface;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces.Concrete
{
    public class ProductRepository : Repository<Product>, IProducts
    {
        private readonly DbContextOperation _context;
        public ProductRepository(DbContextOperation context) : base(context)
        {
            _context = context;
        }

        public async Task<List<ProductModelWiev>> ConvertToDto(List<Product> model)
        {
            List<ProductModelWiev> Liste = new List<ProductModelWiev>();
            foreach (var mod in model)
            {
                ProductModelWiev entity = new ProductModelWiev();

                await Task.Run(() =>
                {
                    var result = (from prod in _context.Products
                                  join color in _context.Colors
                                  on prod.ColorID equals color.ColorID
                                  where color.ColorID==mod.ColorID
                                  select new
                                  {
                                      colorname=color.ColorName
                                  }).FirstOrDefault() ;
                    var result2 = (from prod in _context.Products
                                  join Uses in _context.UseStatuses
                                  on prod.UseStatusID equals Uses.UseStatusID
                                  where Uses.UseStatusID== mod.UseStatusID
                                  select new
                                  {
                                      UsesName = Uses.UseStatusName
                                  }).FirstOrDefault();
                    var result3 = (from prod in _context.Products
                                   join Brand in _context.Brands
                                   on prod.BrandID equals Brand.BrandID
                                   where Brand.BrandID == mod.BrandID
                                   select new
                                   {
                                       BrandName = Brand.BrandName
                                   }).FirstOrDefault();
                    var result4 = _context.Categories.Where(e => e.CategoryID == mod.CategoryID).FirstOrDefault(); 
                    entity.UseStatusName = result2.UsesName;
                    entity.ColorName = result.colorname;
                    entity.BrandName = result3.BrandName;
                    entity.CategoryName = result4.CategoryName ;

                });
                entity.IsOfferable = mod.IsOfferable;
                entity.Price = mod.Price;
                entity.ProductDescription = mod.ProductDescription;
                entity.ProductName = mod.ProductName;
                entity.file = this.GetImage(Convert.ToBase64String(mod.Image));
                Liste.Add(entity);
            }
            return Liste;
        }

        public async Task OverrideCreate(ProductDto model)
        {
            Product entity = new Product();
            await Task.Run(() =>
            {
                var result = (from prod in _context.Products
                              join categ in _context.Categories
                              on prod.CategoryID equals categ.CategoryID
                              where categ.CategoryName == model.CategoryName
                              select new
                              {
                                  CategID=categ.CategoryID
                              }
                          ).FirstOrDefault();
                var result2 = (from prod in _context.Products
                              join brand in _context.Brands
                              on prod.BrandID equals brand.BrandID
                              where brand.BrandName == model.BrandName
                              select new
                              {
                                  BrandID = brand.BrandID
                              }
                          ).FirstOrDefault();
                var result3 = (from prod in _context.Products
                              join color in _context.Colors
                              on prod.ColorID equals color.ColorID
                              where color.ColorName == model.ColorName
                              select new
                              {
                                  ColorID = color.ColorID
                              }
                          ).FirstOrDefault();
                var result4 = (from prod in _context.Products
                              join Uses in _context.UseStatuses
                              on prod.UseStatusID equals Uses.UseStatusID
                              where Uses.UseStatusName == model.UseStatusName
                              select new
                              {
                                  Usesname = Uses.UseStatusID
                              }
                          ).FirstOrDefault();
                entity.BrandID = result2.BrandID;
                
                entity.CategoryID = result.CategID;
                entity.ColorID = result3.ColorID;
                entity.UseStatusID = result4.Usesname;

                entity.ProductDescription = model.ProductDescription;
                entity.IsOfferable = model.IsOfferable;
                entity.Price = model.Price;
                entity.ProductName = model.ProductName;
                entity.UserID = model.UserID;
            });

            if (model.file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    model.file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    entity.Image = fileBytes;
                }
            }
            await Create(entity);

        }
        public Byte[] GetImage(string str)
        {
            byte[] bytes = null;
            if (!string.IsNullOrEmpty(str))
            {
                bytes = Convert.FromBase64String(str);
            }
            return bytes;
        }
    }
}
