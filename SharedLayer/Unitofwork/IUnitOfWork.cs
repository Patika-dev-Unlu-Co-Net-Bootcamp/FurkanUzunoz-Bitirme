using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.Business.Interface;
using UnluCo.Bitirme.DataAcces.Interface;

namespace UnluCo.Bitirme.Business.Unitofwork
{
    public interface IUnitOfWork :IDisposable
    {
        IUserService Users { get; }
        ICategoryService Category { get; }
        IOfferService Offer { get; }

        IAccountService Account { get; }

        IProductService Product { get; }
        Task<int> complete();
    }
}
