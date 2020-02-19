using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Logic
{
    class Reservation
    {
        public Product Product { get; }
        public string Name { get; set; }
        public DateTime DateOfReservation { get; set; }
        public DateTime EndTimeOfReservation { get; set; }
        public Shop Shop { get;  }

        public Reservation(string _name,Shop _shop, Product _product)
        {
            Name = _name;
            Product = _product;
            Shop = _shop;
        }
    }
}
