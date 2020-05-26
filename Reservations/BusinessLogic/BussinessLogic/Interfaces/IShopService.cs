using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic.Interfaces
{
    interface IShopService
    {
        IEnumerable<Shop> GetAll();
        IEnumerable<Shop> GetShopsByProduct(string product);
        Shop GetShopByName(string name);
    }
}
