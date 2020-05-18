using Microsoft.EntityFrameworkCore;
using Reservations.Data.Entities;
using System.Collections.Generic;

namespace Reservations.Data.Repositories
{
    class ProductInShopRepository : IProductInShopRepository
    {
        private DbSet<ProductInShopEntity> _context;
        public ProductInShopRepository(ApplicationContext context)
        {
            _context = context.Set<ProductInShopEntity>();
        }
        public void DeleteById(int Id)
        {
            ProductInShopEntity productInShop = _context.Find(Id);
            _context.Remove(productInShop);
        }

        public IEnumerable<ProductInShopEntity> GetAll()
        {
            return _context.Include(p => p.Product)
                           .Include(s => s.Shop)
                           .AsNoTracking();
        }

        public ProductInShopEntity GetById(int Id)
        {
            return _context.Find(Id);
        }

        public void Insert(ProductInShopEntity entity)
        {
            _context.Add(entity);
        }

        public void Update(ProductInShopEntity entity)
        {
            _context.Update(entity);
        }
    }
}
