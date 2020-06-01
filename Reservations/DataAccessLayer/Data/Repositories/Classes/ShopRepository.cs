using Microsoft.EntityFrameworkCore;
using Entities;
using DataAccessLayer.Implementation.Data.Classes;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Implementation.Data.Repositories.Classes
{
    class ShopRepository :Repository<ShopEntity, int>, IShopRepository
    {
        public ShopRepository(ApplicationContext context)
            :base(context)
        {
        }
        
    }
}
