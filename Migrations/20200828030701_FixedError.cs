using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductsCategories.Migrations
{
    public partial class FixedError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsCategories_Categories_CategoryId",
                table: "ProductsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsCategories_Products_ProductId",
                table: "ProductsCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsCategories",
                table: "ProductsCategories");

            migrationBuilder.RenameTable(
                name: "ProductsCategories",
                newName: "ProductCategories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsCategories_ProductId",
                table: "ProductCategories",
                newName: "IX_ProductCategories_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsCategories_CategoryId",
                table: "ProductCategories",
                newName: "IX_ProductCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories",
                column: "ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Categories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Categories_CategoryId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                newName: "ProductsCategories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_ProductId",
                table: "ProductsCategories",
                newName: "IX_ProductsCategories_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductsCategories",
                newName: "IX_ProductsCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsCategories",
                table: "ProductsCategories",
                column: "ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsCategories_Categories_CategoryId",
                table: "ProductsCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsCategories_Products_ProductId",
                table: "ProductsCategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
