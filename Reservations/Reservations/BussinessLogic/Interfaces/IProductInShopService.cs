using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic.Interfaces
{
    interface IProductInShopService
    {
        IEnumerable<ProductInShop> GetAll();
        ProductInShop GetByProduct(Product product);

    }
}
