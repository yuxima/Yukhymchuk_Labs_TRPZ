﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reservations.Data;

namespace Reservations.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200518191844_reservation")]
    partial class reservation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Reservations.Data.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Name = "Carrot"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Laplop"
                        });
                });

            modelBuilder.Entity("Reservations.Data.Entities.ProductInShopEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShopId");

                    b.ToTable("ProductsInShops");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Count = 4,
                            Price = 2,
                            ProductId = 2,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 2,
                            Count = 1,
                            Price = 17,
                            ProductId = 1,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 1,
                            Count = 3,
                            Price = 23,
                            ProductId = 1,
                            ShopId = 1
                        });
                });

            modelBuilder.Entity("Reservations.Data.Entities.ReservationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfReservation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTimeOfReservation")
                        .HasColumnType("datetime2");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfReservedProduct")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShopId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Reservations.Data.Entities.ShopEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Rozetka"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Prom"
                        });
                });

            modelBuilder.Entity("Reservations.Data.Entities.ProductInShopEntity", b =>
                {
                    b.HasOne("Reservations.Data.Entities.ProductEntity", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reservations.Data.Entities.ShopEntity", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Reservations.Data.Entities.ReservationEntity", b =>
                {
                    b.HasOne("Reservations.Data.Entities.ProductEntity", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reservations.Data.Entities.ShopEntity", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
