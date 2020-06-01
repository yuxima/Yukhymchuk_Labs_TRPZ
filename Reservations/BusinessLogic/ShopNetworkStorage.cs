
using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Implementation
{
    public static class ShopNetworkStorage
    {
        public static List<Product> products { get; set; } = new List<Product>();
        public static List<Reservation> reservations { get; set; } = new List<Reservation>();
        public static List<Shop> shops { get; set; } = new List<Shop>();
    }
}
