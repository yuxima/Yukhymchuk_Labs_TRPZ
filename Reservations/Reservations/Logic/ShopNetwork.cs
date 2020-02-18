using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Logic
{
    static class ShopNetwork
    {
        public static List<Shop> shops { get; set; } = new List<Shop>();
        public static List<Product> products { get; set; } = new List<Product>();
        public static List<Reservation> reservations { get; set; } = new List<Reservation>();


    }
}
