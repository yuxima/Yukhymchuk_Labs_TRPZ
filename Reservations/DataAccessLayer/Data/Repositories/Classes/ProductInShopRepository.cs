using Microsoft.EntityFrameworkCore;
using Reservations.Data.Entities;
using Reservations.Data.Repositories.Classes;
using System.Collections.Generic;

namespace Reservations.Data.Repositories
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
