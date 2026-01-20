using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CraftShopAPI.Migrations
{
    /// <inheritdoc />
    public partial class CraftShopDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseProduct",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    Material = table.Column<string>(type: "TEXT", nullable: true),
                    Color = table.Column<string>(type: "TEXT", nullable: true),
                    HasCushion = table.Column<bool>(type: "INTEGER", nullable: true),
                    NumberOfLegs = table.Column<int>(type: "INTEGER", nullable: true),
                    Style = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CrystalType = table.Column<string>(type: "TEXT", nullable: true),
                    CrystalDecor_Color = table.Column<string>(type: "TEXT", nullable: true),
                    Shape = table.Column<string>(type: "TEXT", nullable: true),
                    IsHandcrafted = table.Column<bool>(type: "INTEGER", nullable: true),
                    CrystalDecor_Name = table.Column<string>(type: "TEXT", nullable: true),
                    Lamp_Name = table.Column<string>(type: "TEXT", nullable: true),
                    Lamp_Material = table.Column<string>(type: "TEXT", nullable: true),
                    Lamp_Color = table.Column<string>(type: "TEXT", nullable: true),
                    HasDimmer = table.Column<bool>(type: "INTEGER", nullable: true),
                    BulbType = table.Column<string>(type: "TEXT", nullable: true),
                    ShadeShape = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseProduct", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerEmail = table.Column<string>(type: "TEXT", nullable: false),
                    ShippingAddress = table.Column<string>(type: "TEXT", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "TEXT", nullable: false),
                    ProductsId = table.Column<string>(type: "TEXT", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvoiceDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerEmail = table.Column<string>(type: "TEXT", nullable: false),
                    BillingAddress = table.Column<string>(type: "TEXT", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "TEXT", nullable: false),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_OrderId",
                table: "Invoices",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseProduct");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
