using AutoMapper;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Data.Entities;

namespace BusinessLogic.Classes
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
