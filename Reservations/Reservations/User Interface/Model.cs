
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.User_Interface
{
    class Model:IModel
    {
        IShopNetwork shopNetwork;
        public Model(IShopNetwork shopNetwork)
        {
            this.shopNetwork = shopNetwork;
        }
        public List<string> GetShops(string nameOfProduct)
        {
            return shopNetwork.GetShops(nameOfProduct);
        }
        public List<string> GetProducts()
        {
            return shopNetwork.GetProducts();
        }
        public void CreateReservation( string product, int numberOfProducts, string shop)
        {
            shopNetwork.CreateReservation(shop, product, numberOfProducts);
        }
    }
}
