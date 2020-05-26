using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IShopService
    {
        public IEnumerable<Shop> GetAll();
        public IEnumerable<Shop> GetShopsByProduct(string product);
        public Shop GetShopByName(string name);
    }
}
