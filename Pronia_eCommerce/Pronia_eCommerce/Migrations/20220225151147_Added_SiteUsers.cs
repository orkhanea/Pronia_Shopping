using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronia_eCommerce.Migrations
{
    public partial class Added_SiteUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SiteUser_CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SiteUser_Image",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SiteUser_Name",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SiteUser_Surname",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SiteUser_CreatedDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SiteUser_Image",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SiteUser_Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SiteUser_Surname",
                table: "AspNetUsers");
        }
    }
}
