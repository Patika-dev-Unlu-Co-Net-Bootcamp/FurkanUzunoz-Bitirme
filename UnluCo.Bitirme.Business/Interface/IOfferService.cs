using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.Business.Interface
{
    public interface IOfferService
    {
        Task<Response> Buy(OffersDto model);
        Task<Response> BackToOffer(OffersDto model);

        Task<Response> GiveOffer(OffersDto model);
        
    }
}
