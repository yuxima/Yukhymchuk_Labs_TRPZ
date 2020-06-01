
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
     public interface IUnitOfWork
    {
        void Commit();
        public IProductRepository ProductRepository { get; }
        public IProductInShopRepository ProductInShopRepository { get; }
        public IShopRepository ShopRepository { get; }
        public IReservationRepository ReservationRepository { get; }
    }
}
