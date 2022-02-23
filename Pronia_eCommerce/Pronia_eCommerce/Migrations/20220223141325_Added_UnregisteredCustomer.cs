using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronia_eCommerce.Migrations
{
    public partial class Added_UnregisteredCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnregisteredCustomerId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UnregisteredCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CountyName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TownCity = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostcodeZip = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Apartment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    OrderNotes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnregisteredCustomers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_UnregisteredCustomerId",
                table: "Sales",
                column: "UnregisteredCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_UnregisteredCustomers_UnregisteredCustomerId",
                table: "Sales",
                column: "UnregisteredCustomerId",
                principalTable: "UnregisteredCustomers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_UnregisteredCustomers_UnregisteredCustomerId",
                table: "Sales");

            migrationBuilder.DropTable(
                name: "UnregisteredCustomers");

            migrationBuilder.DropIndex(
                name: "IX_Sales_UnregisteredCustomerId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "UnregisteredCustomerId",
                table: "Sales");
        }
    }
}
