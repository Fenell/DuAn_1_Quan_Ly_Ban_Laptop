using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL_DataAccessLayer.Migrations
{
    public partial class uppp0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Serial",
                table: "ChiTietHoaDon",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Serial",
                table: "ChiTietHoaDon");
        }
    }
}
