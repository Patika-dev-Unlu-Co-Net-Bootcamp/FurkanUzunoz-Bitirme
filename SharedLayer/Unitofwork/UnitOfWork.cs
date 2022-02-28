using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.Business.Concrete;
using UnluCo.Bitirme.Business.Interface;
using UnluCo.Bitirme.DataAcces;
using UnluCo.Bitirme.DataAcces.Interface;

namespace UnluCo.Bitirme.Business.Unitofwork
{
    public class UnitOfWork : IUnitOfWork
    {
        private  DbContextOperation _context;
        public UnitOfWork(DbContextOperation context,IUserService user,ICategoryService category,IOfferService offer,
            IAccountService account,IProductService product)
        {
            _context = context;
            Users = user;
            Category = category;
            Offer = offer;
            Account = account;
            Product = product;
        }
        public IUserService Users { get; private set; }
        public ICategoryService Category { get; private set; }

        public IOfferService Offer { get; private set; }

        public IAccountService Account { get; private set; }

        public IProductService Product { get; private set; }

        public async Task<int> complete()
        {
            return await _context.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await _context.DisposeAsync();
        }
    }
}
