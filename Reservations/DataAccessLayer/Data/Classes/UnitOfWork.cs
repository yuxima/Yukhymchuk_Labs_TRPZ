using DataAccessLayer.Abstract;
using DataAccessLayer.Implementation.Data.Repositories.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Implementation.Data.Classes
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationContext context;
        private IProductRepository productRepository;
        private IProductInShopRepository productInShopRepository;
        private IShopRepository shopRepository;
        private IReservationRepository reservationRepository;

        public UnitOfWork(ApplicationContext applicationContext)
        {
            context = applicationContext;
        }
        public IProductRepository ProductRepository {
            get
            {
                return productRepository ??
                    (productRepository = new ProductRepository(context));
            }
        }
        public IProductInShopRepository ProductInShopRepository {
            get
            {
                return productInShopRepository ??
                    (productInShopRepository = new ProductInShopRepository(context));
            }
        }
        public IShopRepository ShopRepository {
            get
            {
                return shopRepository ??
                    (shopRepository = new ShopRepository(context));
            }
        }
        public IReservationRepository ReservationRepository {
            get
            {
                return reservationRepository ??
                    (reservationRepository = new ReservationRepository(context));
            }
        }
        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
