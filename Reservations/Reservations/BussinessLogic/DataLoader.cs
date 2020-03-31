using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic
{
    public class DataLoader
    {
        public void LoadData()
        {
            Product product = new Product("apple");
            Product product1 = new Product("cherry");
            Product product2 = new Product("watermelon");
            ShopNetworkStorage.products.Add(product);
            ShopNetworkStorage.products.Add(product1);
            ShopNetworkStorage.products.Add(product2);
            Dictionary<Product, int> productsInShop = new Dictionary<Product, int>();
            productsInShop.Add(product, 2);
            productsInShop.Add(product1, 3);
            Dictionary<Product, int> productsInShop1 = new Dictionary<Product, int>();
            productsInShop.Add(product1, 4);
            productsInShop.Add(product2, 1);
            Dictionary<Product, int> productsInShop2 = new Dictionary<Product, int>();
            productsInShop.Add(product, 3);
            productsInShop.Add(product2, 3);
            Shop shop = new Shop("shop", productsInShop);
            Shop shop1 = new Shop("shop1", productsInShop1);
            Shop shop2 = new Shop("shop2", productsInShop2);
            ShopNetworkStorage.shops.Add(shop);
            ShopNetworkStorage.shops.Add(shop1);
            ShopNetworkStorage.shops.Add(shop2);

        }


    }
}
