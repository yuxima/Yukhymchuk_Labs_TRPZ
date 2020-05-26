using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Shop(string _name)
        {
            Name = _name;
        }
        public Shop()
        {

        }
    }
}
