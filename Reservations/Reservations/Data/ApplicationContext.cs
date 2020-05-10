using Microsoft.EntityFrameworkCore;
using Reservations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data
{
    class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
             : base(options)
        {

        }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ShopEntity> Shops { get; set; }
        public DbSet<ProductInShopEntity> ProductsInShops { get; set; }
        public DbSet<ReservationEntity> Reservations { get; set; }
    }
}
