using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Entities
{
    class ProductEntity:IEntity
    {
        public int Id { get; set; }
        public string Name { get;  set; }
    }
}
