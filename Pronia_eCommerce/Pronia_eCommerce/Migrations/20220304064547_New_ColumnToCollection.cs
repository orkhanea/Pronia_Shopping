using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronia_eCommerce.Migrations
{
    public partial class New_ColumnToCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductCatId",
                table: "CollectionL",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CollectionL_ProductCatId",
                table: "CollectionL",
                column: "ProductCatId");

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionL_ProductCats_ProductCatId",
                table: "CollectionL",
                column: "ProductCatId",
                principalTable: "ProductCats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollectionL_ProductCats_ProductCatId",
                table: "CollectionL");

            migrationBuilder.DropIndex(
                name: "IX_CollectionL_ProductCatId",
                table: "CollectionL");

            migrationBuilder.DropColumn(
                name: "ProductCatId",
                table: "CollectionL");
        }
    }
}
