using Microsoft.EntityFrameworkCore.Migrations;

namespace TedarikYonetim.Dal.Migrations
{
    public partial class v24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Categories_UpperCategoryId",
                table: "Categories",
                column: "UpperCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_UpperCategoryId",
                table: "Categories",
                column: "UpperCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_UpperCategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_UpperCategoryId",
                table: "Categories");
        }
    }
}
