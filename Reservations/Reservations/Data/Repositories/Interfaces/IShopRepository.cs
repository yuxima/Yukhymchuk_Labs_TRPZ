using Reservations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Repositories
{
    interface IShopRepository : IRepository<ShopEntity, int>
    {
        IEnumerable<ShopEntity> GetAll();
        void Insert(ShopEntity model);
        void Update(ShopEntity model);
        ShopEntity GetById(int Id);
        void DeleteById(int Id);
    }
}
