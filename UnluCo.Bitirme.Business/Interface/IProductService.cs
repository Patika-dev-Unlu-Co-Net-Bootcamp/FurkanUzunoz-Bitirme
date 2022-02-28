using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.Business.Interface
{
    public interface IProductService
    {
        Task<Response> Create(ProductDto model);

        Task<List<ProductModelWiev>> GetAll();

        Task<List<ProductModelWiev>> GetProductsFromMein(int id);

    

        Task<Response> Delete(int ProductId);
    }
}
