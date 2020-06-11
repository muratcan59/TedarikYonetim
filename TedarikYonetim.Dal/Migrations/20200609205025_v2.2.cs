using Microsoft.EntityFrameworkCore.Migrations;

namespace TedarikYonetim.Dal.Migrations
{
    public partial class v22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DuyType",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "DuyType",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
