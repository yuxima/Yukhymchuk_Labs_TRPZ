using Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Implementation.Data.Classes;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAccessLayer.Implementation.Data.Repositories.Classes
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
