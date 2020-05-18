using AutoMapper;
using Reservations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic
{
    class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProductEntity, Product>().ReverseMap();
            CreateMap<ProductInShopEntity, ProductEntity>().ReverseMap();
            CreateMap<ShopEntity, Shop>().ReverseMap();
            CreateMap<ReservationEntity, Reservation>().ReverseMap();
        }
    }
}
