using Microsoft.EntityFrameworkCore;
using Reservations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Repositories
{
    class ShopRepository : IShopRepository
    {
        private DbSet<ShopEntity> _context;
        public ShopRepository(ApplicationContext context)
        {
            _context = context.Set<ShopEntity>();
        }
        public void DeleteById(int Id)
        {
            ShopEntity shop = _context.Find(Id);
            _context.Remove(shop);
        }

        public IEnumerable<ShopEntity> GetAll()
        {
            return _context;
        }

        public ShopEntity GetById(int Id)
        {
            return _context.Find(Id);
        }

        public void Insert(ShopEntity entity)
        {
            _context.Add(entity);
        }

        public void Update(ShopEntity entity)
        {
            _context.Update(entity);
        }
    }
}
