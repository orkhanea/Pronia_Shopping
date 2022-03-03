using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronia_eCommerce.Migrations
{
    public partial class Updated_RatingStarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserIp",
                table: "RatingStars",
                newName: "UserSurname");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "RatingStars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "RatingStars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "RatingStars");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "RatingStars");

            migrationBuilder.RenameColumn(
                name: "UserSurname",
                table: "RatingStars",
                newName: "UserIp");
        }
    }
}
