using Microsoft.EntityFrameworkCore.Migrations;

namespace Taste.DataAccess.Migrations
{
    public partial class RenameOrderTotalInOrderHeader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderToal",
                table: "OrderHeader");

            migrationBuilder.AddColumn<double>(
                name: "OrderTotal",
                table: "OrderHeader",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "OrderHeader");

            migrationBuilder.AddColumn<double>(
                name: "OrderToal",
                table: "OrderHeader",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
