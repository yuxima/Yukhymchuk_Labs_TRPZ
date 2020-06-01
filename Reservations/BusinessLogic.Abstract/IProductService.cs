using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Abstract
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAll();
        public Product GetProductByName(string name);
    }
}
