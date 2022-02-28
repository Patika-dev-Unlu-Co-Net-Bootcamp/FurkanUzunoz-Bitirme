using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.Business.Interface;
using UnluCo.Bitirme.DataAcces;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.DataAcces.Interface;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.Business.Concrete
{
    public class AccountService : IAccountService
    {
        private readonly DbContextOperation _context;
        private readonly IMapper _mapper;
        public AccountService(DbContextOperation context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<OfferwithProductDto>> getMyOffers(int id)
        {
            
            var result = new List<OfferwithProductDto>();
            await Task.Run(() => {
                result = (from offer in _context.Offers
                            join prod in _context.Products
                            on offer.ProductID equals prod.ProductID
                            join categ in _context.Categories
                            on prod.CategoryID equals categ.CategoryID
                            join Uses in _context.UseStatuses
                            on prod.UseStatusID equals Uses.UseStatusID
                            join color in _context.Colors
                            on prod.ColorID equals color.ColorID
                            join brand in _context.Brands
                            on prod.BrandID equals brand.BrandID
                            where offer.OfferUserID == id
                            select new OfferwithProductDto
                            {
                                CategoryName = categ.CategoryName,
                                OfferUserID = offer.OfferUserID,
                                BrandName = brand.BrandName,
                                ColorName = color.ColorName,
                                OfferPrice = offer.OfferPrice,
                                Price = prod.Price,
                                ProductDescription = prod.ProductDescription,
                                ProductName = prod.ProductName,
                                UseStatusName = Uses.UseStatusName
                            }).ToList();
            });
            return result ;
        }

        public async Task<List<OfferwithProductDto>> getOffersByMyProduct(int id)
        {
            var entities = new List<OfferwithProductDto>();
            await Task.Run(() => {
                entities = (from offer in _context.Offers
                            join prod in _context.Products
                            on offer.ProductID equals prod.ProductID
                            join categ in _context.Categories
                            on prod.CategoryID equals categ.CategoryID
                            join Uses in _context.UseStatuses
                            on prod.UseStatusID equals Uses.UseStatusID
                            join color in _context.Colors
                            on prod.ColorID equals color.ColorID
                            join brand in _context.Brands
                            on prod.BrandID equals brand.BrandID
                            where prod.UserID == id
                            select new OfferwithProductDto
                            {
                                CategoryName = categ.CategoryName,
                                OfferUserID = offer.OfferUserID,
                                BrandName = brand.BrandName,
                                ColorName = color.ColorName,
                                OfferPrice = offer.OfferPrice,
                                Price = prod.Price,
                                ProductDescription = prod.ProductDescription,
                                ProductName = prod.ProductName,
                                UseStatusName = Uses.UseStatusName
                            }).ToList() ;
                

            });
            return entities ;
        }

        public async Task<Response> OkOrNot(int OfferID,bool data)
        {
            if (data)
            {
                try
                {
                    await Task.Run(() =>
                    {
                        var result =_context.Offers.Find(OfferID);
                        result.isOfferActive = false;
                        _context.Offers.Update(result);

                        var result2 = _context.Products.Find(result.ProductID);
                        result2.IsSold = true;
                        _context.Products.Update(result2);

                    });
                    return new Response { Message = "satın alma gerçekleşti.", State = 1, StatusCode = 200 } ;
                }
                catch (Exception)
                {
                    return new Response { Message = "satın alma hatalı", StatusCode = 401, State = 0 };
                }
                

            }
            else
            {
                await Task.Run(() =>
                {
                    var result = _context.Offers.Find(OfferID);
                    result.isOfferActive = false;
                    _context.Offers.Update(result);
                });

                return new Response { Message = "Reddetme işlemi başarılı", State = 1, StatusCode = 200 };
            }
        }
    }
}
