using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic
{
    public class Reservation
    {
        public int Id { get; set; }
        public Product Product { get; set; }

        public int ProductId { get; set; }
        public int Number { get;  set; }
        public DateTime DateOfReservation { get;  set; }
        public DateTime EndTimeOfReservation { get;  set; }
        public Shop Shop { get; set; }
        public int ShopId { get; set; }
        public int NumberOfReservedProduct { get; set; }

        public Reservation( Shop _shop, Product _product, int _numbersOfProd)
        {
            Product = _product;
            Shop = _shop;
            NumberOfReservedProduct = _numbersOfProd;
        }
        public Reservation()
        {

        }
    }
}
