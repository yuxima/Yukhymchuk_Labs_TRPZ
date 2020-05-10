using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic
{
    class ProductInShop
    {
        public int Id { get; set; }
        public int IdShop { get; set; }
        public int IdProduct { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public Shop Shop { get; set; }
        public Product Product { get; set; }
        public ProductInShop(int idShop, int idProduct, int price, int count, Shop shop, Product product)
        {
            IdShop = idShop;
            IdProduct = idProduct;
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
