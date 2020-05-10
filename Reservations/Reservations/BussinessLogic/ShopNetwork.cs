using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic
{
    class ShopNetwork:IShopNetwork
    {
        ReservationCreator reservationCreator;
        public ShopNetwork(ReservationCreator reservationCreator, DataLoader dataLoader)
        {
            this.reservationCreator = reservationCreator;
            dataLoader.LoadData();
        }
        
        public List<string> GetProducts()
        {
            List<string> productsNames = new List<string>();
            foreach (Product product in ShopNetworkStorage.products)
            {
                productsNames.Add(product.Name);
            }
            return productsNames;
        }

        public List<string> GetShops(string nameOfProduct)
        {
            List<string> shopsNames = new List<string>();
            foreach (Shop shop in ShopNetworkStorage.shops)
            {
                if (shop.ProductsInShop.ContainsKey(GetProduct(nameOfProduct)))
                {
                    shopsNames.Add(shop.Name);
                }
                
                    
            }
            return shopsNames;
        }
        private Product GetProduct(string nameOfProduct)
        {
            foreach (Product product in ShopNetworkStorage.products)
            {
                if (nameOfProduct == product.Name)
                {
                    return product;

                }
            }
            return null;
        }
        private Shop GetShop(string nameOfShop)
        {

            foreach (Shop shop in ShopNetworkStorage.shops)
            {
                if (nameOfShop == shop.Name)
                {
                    return shop;
                }
            }
            return null;
        }
        public void CreateReservation(int reservation, string shop, string product, int numberOfProducts)
        {
            GetShop(shop);
            GetProduct(product);
            reservationCreator.CreateReservation(GetShop(shop), GetProduct(product), reservation, numberOfProducts);
        }
    }
}