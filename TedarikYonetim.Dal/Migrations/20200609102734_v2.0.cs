using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TedarikYonetim.Dal.Migrations
{
    public partial class v20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryCode = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    UpperCategoryId = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    UpperCategoryId = table.Column<int>(nullable: false),
                    SubCategoryId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpperCategoryId = table.Column<int>(nullable: false),
                    SubCategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SupplierId = table.Column<int>(nullable: false),
                    SupplierGetType = table.Column<string>(nullable: true),
                    BuyPrice = table.Column<double>(nullable: false),
                    Material = table.Column<string>(nullable: true),
                    Pattern = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    DuyType = table.Column<string>(nullable: true),
                    PacketContent = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ProductFix = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    ProductState = table.Column<string>(nullable: true),
                    ProductWidth = table.Column<int>(nullable: false),
                    ProductDepth = table.Column<int>(nullable: false),
                    ProductHeight = table.Column<int>(nullable: false),
                    ProductWeight = table.Column<double>(nullable: false),
                    ModuleCBM = table.Column<double>(nullable: false),
                    KDV = table.Column<double>(nullable: false),
                    PacketAmount = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    Fax = table.Column<int>(nullable: false),
                    MobilePhone = table.Column<int>(nullable: false),
                    WebUrl = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    TaxPlace = table.Column<string>(nullable: true),
                    TaxNo = table.Column<int>(nullable: false),
                    DeliveryType = table.Column<string>(nullable: true),
                    PayType = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSurname = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
