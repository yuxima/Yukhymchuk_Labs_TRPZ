using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Classes
{
    public class ShopNetwork:IShopNetwork
    {
        ReservationCreator reservationCreator;
        IShopService shopService;
        IProductService productService;
        public ShopNetwork(ReservationCreator reservationCreator, IShopService shopService, IProductService productService, DataLoader dataLoader)
        {
            this.reservationCreator = reservationCreator;
            this.productService = productService;
            this.shopService = shopService;
            dataLoader.LoadData();
        }
        
        public List<string> GetProducts()
        {
            var products = productService.GetAll().Select(p => p.Name).ToList();
            return products;
        }

        public List<string> GetShops(string nameOfProduct)
        {
            var shops = shopService.GetShopsByProduct(nameOfProduct).Select(s=>s.Name).ToList();
            return shops;
        }
        private Product GetProduct(string nameOfProduct)
        {
            var product = productService.GetProductByName(nameOfProduct);
            return product;
        }
        private Shop GetShop(string nameOfShop)
        {
            var shop = shopService.GetShopByName(nameOfShop);
            return shop;
        }
        public void CreateReservation(string shop, string product, int numberOfProducts)
        {
            GetShop(shop);
            GetProduct(product);
            reservationCreator.CreateReservation(GetShop(shop), GetProduct(product), numberOfProducts);
        }
    }
}