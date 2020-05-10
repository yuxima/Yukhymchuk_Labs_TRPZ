using Reservations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Repositories
{
    interface IProductInShopRepository:IRepository<ProductInShopEntity, int>
    {
        IEnumerable<ProductInShopEntity> GetAll();
        void Insert(ProductInShopEntity model);
        void Update(ProductInShopEntity model);
        ProductInShopEntity GetById(int Id);
        void DeleteById(int Id);
    }
}
