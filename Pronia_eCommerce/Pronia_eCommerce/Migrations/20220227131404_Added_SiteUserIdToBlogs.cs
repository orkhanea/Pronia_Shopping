using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronia_eCommerce.Migrations
{
    public partial class Added_SiteUserIdToBlogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SiteUserId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_SiteUserId",
                table: "Blogs",
                column: "SiteUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_SiteUserId",
                table: "Blogs",
                column: "SiteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_SiteUserId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_SiteUserId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "SiteUserId",
                table: "Blogs");
        }
    }
}
