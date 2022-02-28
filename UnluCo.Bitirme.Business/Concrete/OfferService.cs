using AutoMapper;
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
    public class OfferService : IOfferService
    {
        private readonly IMapper _mapper;
        private readonly IOffer _offer;
        public OfferService(IMapper mapper,IOffer offer)
        {
            _mapper = mapper;
            _offer = offer;
        }
        public async Task<Response> BackToOffer(OffersDto model)
        {
            try
            {
                var entity = _mapper.Map<Offers>(model);
                await _offer.BackOffer(entity);
                return new Response { Message = "Başarı ile teklif geri çekildi.", State = 1, StatusCode = 200 };
            }
            catch (Exception)
            {
                return new Response { Message = "Teklif Geri Çekilirken bir hata meydana geldi.", State = 0, StatusCode = 401 };
            }
            
        }

        public async Task<Response> Buy(OffersDto model)
        {
            try
            {
                var entity = _mapper.Map<Offers>(model);
                entity.isOfferActive = false;
                await _offer.Buy(entity);
                return new Response { Message = "Başarı ile Satın alma işlemi gerçekleşti.", State = 1, StatusCode = 200 };
            }
            catch (Exception)
            {
                return new Response { Message = "Satın alma işlemi esnasında bir hata meydana geldi.", State = 0, StatusCode = 401 };
            }
            
        }

        public async Task<Response> GiveOffer(OffersDto model)
        {
            try
            {
                if (await _offer.isofferable(model.ProductID))
                {
                    var offerprice = 0;
                    if (model.OfferPrice[0] == '%')
                    {
                        var a = model.OfferPrice.Length;
                        List<char> liste = new List<char>();
                        for (int i = 1; i < a; i++)
                        {
                            liste.Add(model.OfferPrice[i]);
                        }
                        string newprice = new string(liste.ToArray());
                        offerprice = Int32.Parse(newprice);
                        var productPrice = _offer.giveprice(model.ProductID);

                        offerprice = (offerprice * productPrice) / 100;
                    }
                    else
                    {
                        offerprice = Int32.Parse(model.OfferPrice);
                    }
                    var entity = _mapper.Map<Offers>(model);
                    entity.OfferPrice = offerprice;
                    await _offer.Create(entity);
                    return new Response { Message = "Başarı ile Teklif verildi.", State = 1, StatusCode = 200 };
                }
                return new Response { Message = "Ürün Teklif verilebilir değil.", State = 0, StatusCode = 401 };

            }
            catch (Exception)
            {
                return new Response { Message = "Teklif verme işlemi esnasında bir hata meydana geldi.", State = 0, StatusCode = 401 };
            }
            
        }
    }
}
