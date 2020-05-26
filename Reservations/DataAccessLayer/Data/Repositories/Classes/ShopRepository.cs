using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Data.Classes;
using DataAccessLayer.Data.Entities;
using DataAccessLayer.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Repositories.Classes
{
    class ShopRepository :Repository<ShopEntity, int>, IShopRepository
    {
        public ShopRepository(ApplicationContext context)
            :base(context)
        {
        }
        
    }
}
