using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces.Interface
{
    public interface ICategory:IRepository<Category>
    {
        Task<List<ProductsbycategoryDto>> GetProductByCategoryId(int id);

    }
}
