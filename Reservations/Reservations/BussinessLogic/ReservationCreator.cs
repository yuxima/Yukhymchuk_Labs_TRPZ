using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic
{
    class ReservationCreator
    {
        Reservation myReservation;
        public void CreateReservation(Shop shop, Product product, int numberOfReservation, int numberOfProducts)
        {
            if (IsAvailabile() == true)
            {
                myReservation = new Reservation(numberOfReservation, shop, product, numberOfProducts);
                ShopNetworkStorage.reservations.Add(myReservation);
            }
            else
            {
                throw new Exception("Reservation isn't created");
            }
            
        }
        public bool IsAvailabile()
        {
            foreach(KeyValuePair<Product,int> product in myReservation.Shop.ProductsInShop)
            {
                if(product.Key == myReservation.Product && product.Value <= myReservation.Number)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
