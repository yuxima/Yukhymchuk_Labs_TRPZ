using DataAccessLayer.Data.Classes;
using DataAccessLayer.Data.Entities;
using DataAccessLayer.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAccessLayer.Data.Repositories.Classes
{
    class ProductInShopRepository : Repository<ProductInShopEntity, int>,IProductInShopRepository
    {
        public ProductInShopRepository(ApplicationContext context):
            base(context)
        {
        }
        public override IEnumerable<ProductInShopEntity> GetAll()
        {
            return _context.AsNoTracking()
                           .Include(p=>p.Product)
                           .Include(s=>s.Shop);
        }
    }
}
