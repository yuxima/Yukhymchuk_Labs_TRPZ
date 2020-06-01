using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using BusinessLogic.Models;

namespace BusinessLogic.Implementation.Classes
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProductEntity, Product>().ReverseMap();
            CreateMap<ProductInShopEntity, ProductInShop>().ReverseMap();
            CreateMap<ShopEntity, Shop>().ReverseMap();
            CreateMap<ReservationEntity, Reservation>().ReverseMap();
        }
    }
}
