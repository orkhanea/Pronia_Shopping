using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronia_eCommerce.Migrations
{
    public partial class NewColumnToCollectionS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductCatId",
                table: "CollectionS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CollectionS_ProductCatId",
                table: "CollectionS",
                column: "ProductCatId");

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionS_ProductCats_ProductCatId",
                table: "CollectionS",
                column: "ProductCatId",
                principalTable: "ProductCats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollectionS_ProductCats_ProductCatId",
                table: "CollectionS");

            migrationBuilder.DropIndex(
                name: "IX_CollectionS_ProductCatId",
                table: "CollectionS");

            migrationBuilder.DropColumn(
                name: "ProductCatId",
                table: "CollectionS");
        }
    }
}
