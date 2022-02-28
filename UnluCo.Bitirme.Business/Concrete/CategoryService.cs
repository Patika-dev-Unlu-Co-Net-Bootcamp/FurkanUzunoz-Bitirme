using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.Business.Interface;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.DataAcces.Interface;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategory _category;
        public CategoryService(ICategory category)
        {
            _category = category;
        }

        public async Task<Response> CreateCategory(Category model)
        {
            try
            {
                await _category.Create(model);
                return new Response { Message = "Başarı ile kategori oluşturuldu." ,State=1,StatusCode=200 };
            }
            catch (Exception)
            {
                return new Response { Message = "Kategori oluşturma işleminde hata mevcut", State = 0, StatusCode = 401 };
            } 
        }

        public async Task<List<Category>> GetAllCategories()
        {
            try
            {
                return await _category.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task<List<ProductsbycategoryDto>> GetProductsUsingCategoryid(int id)
        {
           return await _category.GetProductByCategoryId(id);
        }

        public async Task<Response> UpdateCategory(Category model)
        {
            try
            {
                await _category.Update(model);
                return new Response { Message = "Başarı ile kategori Güncellendi.", State = 1, StatusCode = 200 };
            }
            catch (Exception)
            {

                return new Response { Message = "Kategori Güncelleme işleminde hata mevcut", State = 0, StatusCode = 401 };
            }
            
        }
    }
}
