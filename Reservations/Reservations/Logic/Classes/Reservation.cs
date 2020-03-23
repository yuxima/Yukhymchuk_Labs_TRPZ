using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Logic
{
    class Reservation
    {
        public Product Product { get; }
        public int Number { get; set; }
        public DateTime DateOfReservation { get; set; }
        public DateTime EndTimeOfReservation { get; set; }
        public Shop Shop { get;  }

        public Reservation(int _number, Shop _shop, Product _product)
        {
            Number = _number;
            Product = _product;
            Shop = _shop;
        }
    }
}
