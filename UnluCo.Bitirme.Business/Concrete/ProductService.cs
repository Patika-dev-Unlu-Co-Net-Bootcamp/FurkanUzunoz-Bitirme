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
    public class ProductService : IProductService
    {
        private readonly IProducts _prod;
        public ProductService(IProducts prod)
        {
            _prod = prod;
        }
        public async Task<Response> Create(ProductDto model)
        {
            try
            {
                await _prod.OverrideCreate(model);
                return new Response { Message = "başarı ile ürün kayıt edildi." ,State=1,StatusCode=200};
            }
            catch (Exception)
            {
                return new Response { Message = "Ürün eklenirken hata ile karşılaşıldı.", State = 0, StatusCode = 500 };
            }
            
        }

        public async Task<Response> Delete(int ProductId)
        {
            try
            {
                await _prod.Delete(ProductId);
                return new Response { Message = "başarı ile ürün silindi.", State = 1, StatusCode = 200 };
            }
            catch (Exception)
            {
                return new Response { Message = "Ürün silinemedi.", State = 0, StatusCode = 500 };
            }
            
        }

        public async Task<List<ProductModelWiev>> GetAll()
        {
            
            try
            {
                var result = await _prod.GetAll();
                var result2 = await _prod.ConvertToDto(result);
                return result2;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<ProductModelWiev>> GetProductsFromMein(int id)
        {
            List<ProductModelWiev> model = new List<ProductModelWiev>();
            try
            {
                var result = await _prod.GetAll();
                var result2 = result.Where(e => e.UserID == id).ToList();
                if (result2 is not null)
                {
                    return await _prod.ConvertToDto(result2);
                }
                return model;
            }
            catch (Exception)
            {

                return model;
            }
        }

        
    }
}
