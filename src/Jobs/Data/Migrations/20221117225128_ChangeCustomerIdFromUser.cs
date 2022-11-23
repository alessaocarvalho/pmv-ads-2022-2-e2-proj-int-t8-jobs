using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs.Data.Migrations
{
    public partial class ChangeCustomerIdFromUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Works");

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Works",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "Works");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Works",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
