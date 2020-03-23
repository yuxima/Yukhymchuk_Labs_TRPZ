using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Logic
{
    class ReservationCreator
    {
        Reservation reservation;
        public ReservationCreator(string nameOfChosedProduct, string nameOfChosedShop, string nameOfReservation)
        {
            reservation = new Reservation(nameOfReservation, ChooseShop(nameOfChosedShop), ChooseProduct(nameOfChosedProduct, ChooseShop(nameOfChosedShop)));

        }
        private Shop ChooseShop(string _nameOfShop)
        {
            foreach (Shop shop in ShopNetwork.shops)
            {
                if (shop.Name == _nameOfShop)
                {
                    return shop;
                }
                else throw new Exception("There is no such shop");
            }
            return null;
        }
        public Product ChooseProduct(string _nameOfProduct, Shop _shop)
        {
            foreach(KeyValuePair<Product, int> product in _shop.ProductsInShop)
            {
                if (product.Key.Name == _nameOfProduct)
                {
                    return product.Key;
                }
                else throw new Exception("There is no such product in shop");
            }
            return null;
        }
    }
}
