﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Entities
{
    public class ProductEntity:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get;  set; }
    }
}
