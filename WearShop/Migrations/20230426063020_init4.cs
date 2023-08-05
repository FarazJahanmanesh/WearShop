using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WearShop.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesProductsProduct");

            migrationBuilder.DropTable(
                name: "CategoriesProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Slider",
                table: "Slider");

            migrationBuilder.RenameTable(
                name: "Slider",
                newName: "Sliders");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Products",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "off",
                table: "Products",
                newName: "Off");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "Products",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "Products",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "imageName",
                table: "Products",
                newName: "ImageName");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "createDate",
                table: "Products",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "url",
                table: "Sliders",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Sliders",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Sliders",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sliders",
                table: "Sliders",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoryId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sliders",
                table: "Sliders");

            migrationBuilder.RenameTable(
                name: "Sliders",
                newName: "Slider");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Products",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Off",
                table: "Products",
                newName: "off");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Products",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "imageUrl");

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Products",
                newName: "imageName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Products",
                newName: "createDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Slider",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Slider",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Slider",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Slider",
                table: "Slider",
                column: "id");

            migrationBuilder.CreateTable(
                name: "CategoriesProducts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesProducts", x => x.id);
                });

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
    }
}
