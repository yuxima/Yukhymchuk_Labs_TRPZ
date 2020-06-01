using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IShopRepository : IRepository<ShopEntity, int>
    {
    }
}
