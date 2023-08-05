using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WearShop.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "categoriesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "CategoriesProducts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoriesId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "productId",
                table: "CategoriesProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
