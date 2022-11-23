using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs.Data.Migrations
{
    public partial class CreateImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Works");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Works",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Works");

            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "Works",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
