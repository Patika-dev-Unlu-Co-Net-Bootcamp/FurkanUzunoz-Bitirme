using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.Business.Interface
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategories();
        Task<List<ProductsbycategoryDto>> GetProductsUsingCategoryid(int id);
        Task<Response> CreateCategory(Category model);
        Task<Response> UpdateCategory(Category model);
    }

}
