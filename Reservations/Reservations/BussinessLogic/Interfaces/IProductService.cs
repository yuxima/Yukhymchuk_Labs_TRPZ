using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic.Interfaces
{
    interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetProductByName(string name);
    }
}
