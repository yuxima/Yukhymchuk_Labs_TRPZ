using DataAccessLayer.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Interfaces
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
