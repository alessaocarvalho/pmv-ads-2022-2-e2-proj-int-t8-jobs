using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs.Data.Migrations
{
    public partial class CreateWorkFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Works",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EndTime",
                table: "Works",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Works",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Works",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "StartTime",
                table: "Works",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Works");
        }
    }
}
