using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Concrete;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces.Interface
{
    public interface IOffer : IRepository<Offers>
    {
        Task Buy(Offers model);
        Task BackOffer(Offers model);
        public int giveprice(int id);
        Task<bool> isofferable(int id);
    }
}
