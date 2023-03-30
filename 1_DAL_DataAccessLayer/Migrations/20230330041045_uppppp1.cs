using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL_DataAccessLayer.Migrations
{
    public partial class uppppp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HinhThucNhanHang",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "TrangThaiGH",
                table: "HoaDon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HinhThucNhanHang",
                table: "HoaDon",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TrangThaiGH",
                table: "HoaDon",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
