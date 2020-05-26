using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product(string _name)
        {
            Name = _name;
        }
        public Product()
        {

        }
    }
}
