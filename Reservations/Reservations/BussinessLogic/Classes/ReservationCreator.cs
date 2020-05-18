using Reservations.BussinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic
{
    class ReservationCreator
    {
        Reservation myReservation;
        private IReservationService _reservationService;
        private IProductInShopService _productInShopService;
        public ReservationCreator(IReservationService reservationService, IProductInShopService productInShopService)
        {
            _reservationService = reservationService;
            _productInShopService = productInShopService;
        }
        public void CreateReservation(Shop shop, Product product, int numberOfProducts)
        {
            if (IsAvailabile(product, numberOfProducts) == true)
            {
                _reservationService.CreateReservation(shop, product, numberOfProducts);
            }
            else
            {
                throw new Exception("Reservation isn't created");
            }
        }
        public bool IsAvailabile(Product product, int numberOfProducts)
        {
            ProductInShop productInShop = _productInShopService.GetByProduct(product);
            if (numberOfProducts <= productInShop.Count) return true;
            else return false;
        }
    }
}
