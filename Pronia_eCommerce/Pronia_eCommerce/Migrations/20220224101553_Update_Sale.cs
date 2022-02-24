using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronia_eCommerce.Migrations
{
    public partial class Update_Sale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_UnregisteredCustomers_UnregisteredCustomerId",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "UnregisteredCustomerId",
                table: "Sales",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_UnregisteredCustomers_UnregisteredCustomerId",
                table: "Sales",
                column: "UnregisteredCustomerId",
                principalTable: "UnregisteredCustomers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_UnregisteredCustomers_UnregisteredCustomerId",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "UnregisteredCustomerId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_UnregisteredCustomers_UnregisteredCustomerId",
                table: "Sales",
                column: "UnregisteredCustomerId",
                principalTable: "UnregisteredCustomers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
