using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WearShop.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CategoriesProductsProduct",
                columns: table => new
                {
                    categoriesid = table.Column<int>(type: "int", nullable: false),
                    productid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesProductsProduct", x => new { x.categoriesid, x.productid });
                    table.ForeignKey(
                        name: "FK_CategoriesProductsProduct_CategoriesProducts_categoriesid",
                        column: x => x.categoriesid,
                        principalTable: "CategoriesProducts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesProductsProduct_Products_productid",
                        column: x => x.productid,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesProductsProduct_productid",
                table: "CategoriesProductsProduct",
                column: "productid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesProductsProduct");

            migrationBuilder.DropColumn(
                name: "categoriesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "CategoriesProducts");
        }
    }
}
