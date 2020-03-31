using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic
{
    public class Shop
    {
        public string Name { get; set; }
        public Dictionary<Product, int> ProductsInShop { get; set; }

        public Shop(string _name, Dictionary<Product, int> _productsInShop)
        {
            Name = _name;
            ProductsInShop = _productsInShop;
        }
    }
}
