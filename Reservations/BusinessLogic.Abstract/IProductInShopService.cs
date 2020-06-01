
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Abstract
{
    public interface IProductInShopService
    {
        public IEnumerable<ProductInShop> GetAll();
        public ProductInShop GetByProduct(Product product);

    }
}
