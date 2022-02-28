using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.Business.Interface
{
    public interface IAccountService
    {
        Task<List<OfferwithProductDto>> getMyOffers(int id);
        Task<List<OfferwithProductDto>> getOffersByMyProduct(int id);
        Task<Response> OkOrNot(int ProductID,bool data);

    }
}
