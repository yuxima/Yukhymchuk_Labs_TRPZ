using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
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
