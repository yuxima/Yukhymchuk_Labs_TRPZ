using Reservations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Repositories
{
    interface IShopRepository : IRepository<ShopEntity, int>
    {
    }
}
