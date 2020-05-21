using Microsoft.EntityFrameworkCore;
using Reservations.BussinessLogic;
using Reservations.Data.Entities;
using Reservations.Data.Repositories.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Repositories
{
    class ShopRepository :Repository<ShopEntity, int>, IShopRepository
    {
        public ShopRepository(ApplicationContext context)
            :base(context)
        {
        }
        
    }
}
