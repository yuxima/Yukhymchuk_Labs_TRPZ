using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Entities
{
    class ProductInShopEntity : IEntity
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public ShopEntity Shop { get; set; }
        public ProductEntity Product { get; set; }
    }
}
