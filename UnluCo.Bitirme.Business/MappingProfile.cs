using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.Business
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<IDPass, Users>();
            CreateMap<Users,IDPass >();
            CreateMap<Users, UsersDto>();
            CreateMap<UsersDto, Users>();
            CreateMap<Offers, OffersDto>().ForMember(src=>src.OfferPrice , opt=> opt.Ignore());
            CreateMap<OffersDto, Offers>().ForMember(src=>src.OfferPrice,opt=> opt.MapFrom(dst=> Int32.Parse(dst.OfferPrice))) ;
        }
    }
}
