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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var rozetka = new ShopEntity
            {
                Name = "Rozetka",
                Id = 1
            };
            var prom = new ShopEntity
            {
                Name = "Prom",
                Id = 2
            };
            var laptop = new ProductEntity
            {
                Name = "Laplop",
                Id = 1
            };
            var carrot = new ProductEntity
            {
                Name = "Carrot",
                Id = 2
            };
            var laptopInRozeka = new ProductInShopEntity
            {
                Id = 1,
                Count = 3,
                IdProduct = laptop.Id,
                IdShop = rozetka.Id,
                Price = 23
            };
            var laptopInProm = new ProductInShopEntity
            {
                Id = 2,
                Count = 1,
                IdShop = prom.Id,
                IdProduct = laptop.Id,
                Price = 17
            };
            var carrotInRozetka = new ProductInShopEntity
            {
                Id = 3,
                Count = 4,
                IdProduct = carrot.Id,
                IdShop = rozetka.Id,
                Price = 2
            };
            modelBuilder.Entity<ProductEntity>().HasData(carrot, laptop);
            modelBuilder.Entity<ShopEntity>().HasData(rozetka, prom);
            modelBuilder.Entity<ProductInShopEntity>().HasData(carrotInRozetka, laptopInProm, laptopInRozeka);

        }
    }
}
