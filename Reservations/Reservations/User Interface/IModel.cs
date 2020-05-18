using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.User_Interface
{
    interface IModel
    {
        void CreateReservation(string product, int numberOfProducts, string shop);
        List<string> GetShops(string nameOfProduct);
        List<string> GetProducts();
    }
}
