using Reservations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data
{
    interface IUnitOfWork
    {
        void Commit();
        IProductRepository ProductRepository { get; }
        IProductInShopRepository ProductInShopRepository { get; }
        IShopRepository ShopRepository { get; }
        IReservationRepository ReservationRepository { get; }
    }
}
