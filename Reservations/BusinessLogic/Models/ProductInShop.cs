using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class ProductInShop
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public Shop Shop { get; set; }
        public Product Product { get; set; }
        public ProductInShop(int shopId, int productId, int price, int count, Shop shop, Product product)
        {
            ShopId = shopId;
            ProductId = productId;
            Shop = shop;
            Product = product;
            Price = price;
            Count = count;
        }
        public ProductInShop()
        {

        }
    }
}
