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
    public class OfferRepository : Repository<Offers>, IOffer
    {
        private readonly DbContextOperation _context;
        public OfferRepository(DbContextOperation context) : base(context)
        {
            _context = context;
        }
        public async Task BackOffer(Offers model)
        {
            var entity = new Offers();
            await Task.Run(() => { 
                entity=_context.Offers.Where(x => x.OfferUserID == model.OfferUserID && x.ProductID == model.ProductID).FirstOrDefault() ; });
            entity.isOfferActive = false;
            await Update(entity);
        }

        public async Task Buy(Offers model)
        {
            await Task.Run(() =>
            {
                var entity=_context.Products.Where(e => e.ProductID == model.ProductID).FirstOrDefault();
                entity.IsSold = true;
                _context.Products.Update(entity);
                
            // veri tabanında değişikşik olmazsa save changes unutma
            });
            await Create(model);
            
        }
        public int giveprice(int id)
        {
           var entity = _context.Products.Where(e => e.ProductID == id).FirstOrDefault();
           return entity.Price;
        }

        public async Task<bool> isofferable(int id)
        {
            var result = await _context.Products.FindAsync(id) ;
            return result.IsOfferable ;
        }
    }
}
