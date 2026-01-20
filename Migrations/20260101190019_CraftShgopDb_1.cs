using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CraftShopAPI.Migrations
{
    /// <inheritdoc />
    public partial class CraftShgopDb_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BulbType",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "CrystalDecor_Color",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "CrystalDecor_Name",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "CrystalType",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "HasCushion",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "HasDimmer",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "IsHandcrafted",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "Lamp_Color",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "Lamp_Material",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "Lamp_Name",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "Material",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "NumberOfLegs",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "ShadeShape",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "Shape",
                table: "BaseProduct");

            migrationBuilder.DropColumn(
                name: "Style",
                table: "BaseProduct");

            migrationBuilder.CreateTable(
                name: "Chair",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Material = table.Column<string>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    HasCushion = table.Column<bool>(type: "INTEGER", nullable: false),
                    NumberOfLegs = table.Column<int>(type: "INTEGER", nullable: false),
                    Style = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chair", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Chair_BaseProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "BaseProduct",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrystalDecor",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CrystalType = table.Column<string>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    Shape = table.Column<string>(type: "TEXT", nullable: false),
                    IsHandcrafted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrystalDecor", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_CrystalDecor_BaseProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "BaseProduct",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lamp",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Material = table.Column<string>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    HasDimmer = table.Column<bool>(type: "INTEGER", nullable: false),
                    BulbType = table.Column<string>(type: "TEXT", nullable: false),
                    ShadeShape = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lamp", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Lamp_BaseProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "BaseProduct",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chair");

            migrationBuilder.DropTable(
                name: "CrystalDecor");

            migrationBuilder.DropTable(
                name: "Lamp");

            migrationBuilder.AddColumn<string>(
                name: "BulbType",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CrystalDecor_Color",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CrystalDecor_Name",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CrystalType",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseProduct",
                type: "TEXT",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasCushion",
                table: "BaseProduct",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasDimmer",
                table: "BaseProduct",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHandcrafted",
                table: "BaseProduct",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lamp_Color",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lamp_Material",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lamp_Name",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfLegs",
                table: "BaseProduct",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShadeShape",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shape",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Style",
                table: "BaseProduct",
                type: "TEXT",
                nullable: true);
        }
    }
}
