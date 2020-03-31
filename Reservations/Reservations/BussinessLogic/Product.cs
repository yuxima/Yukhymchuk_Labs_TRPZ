using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic
{
    public class Product
    {
        public string Name { get; private set; }
        public int AvailibleNumber { get; private set; }

        public Product(string _name)
        {
            Name = _name;
        }
    }
}
