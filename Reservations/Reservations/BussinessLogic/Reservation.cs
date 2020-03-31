using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic
{
    public class Reservation
    {
        public Product Product { get; }
        public int Number { get; private set; }
        public DateTime DateOfReservation { get; private set; }
        public DateTime EndTimeOfReservation { get; private set; }
        public Shop Shop { get;  }
        public int NumberOfReservedProduct { get; set; }

        public Reservation(int _number, Shop _shop, Product _product, int _numbersOfProd)
        {
            Number = _number;
            Product = _product;
            Shop = _shop;
            NumberOfReservedProduct = _numbersOfProd;
        }
    }
}
