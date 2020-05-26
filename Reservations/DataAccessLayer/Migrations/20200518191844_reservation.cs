using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reservations.Migrations
{
    public partial class reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsInShops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInShops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsInShops_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsInShops_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    DateOfReservation = table.Column<DateTime>(nullable: false),
                    EndTimeOfReservation = table.Column<DateTime>(nullable: false),
                    ShopId = table.Column<int>(nullable: false),
                    NumberOfReservedProduct = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Carrot" },
                    { 1, "Laplop" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Rozetka" },
                    { 2, "Prom" }
                });

            migrationBuilder.InsertData(
                table: "ProductsInShops",
                columns: new[] { "Id", "Count", "Price", "ProductId", "ShopId" },
                values: new object[] { 3, 4, 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "ProductsInShops",
                columns: new[] { "Id", "Count", "Price", "ProductId", "ShopId" },
                values: new object[] { 1, 3, 23, 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductsInShops",
                columns: new[] { "Id", "Count", "Price", "ProductId", "ShopId" },
                values: new object[] { 2, 1, 17, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInShops_ProductId",
                table: "ProductsInShops",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInShops_ShopId",
                table: "ProductsInShops",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ProductId",
                table: "Reservations",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ShopId",
                table: "Reservations",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsInShops");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
