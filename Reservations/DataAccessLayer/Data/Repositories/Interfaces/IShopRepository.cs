using DataAccessLayer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Repositories.Interfaces
{
    public interface IShopRepository : IRepository<ShopEntity, int>
    {
    }
}
