using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL_DataAccessLayer.Migrations
{
    public partial class upp3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TrongLuong",
                table: "Laptop",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaNhap",
                table: "Laptop",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaBan",
                table: "Laptop",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaTri",
                table: "KhuyenMai",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TongTien",
                table: "HoaDon",
                type: "decimal(18,0)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "ThanhTien",
                table: "ChiTietHoaDon",
                type: "decimal(18,0)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "DonGia",
                table: "ChiTietHoaDon",
                type: "decimal(18,0)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldDefaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TrongLuong",
                table: "Laptop",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaNhap",
                table: "Laptop",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaBan",
                table: "Laptop",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaTri",
                table: "KhuyenMai",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TongTien",
                table: "HoaDon",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "ThanhTien",
                table: "ChiTietHoaDon",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "DonGia",
                table: "ChiTietHoaDon",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldDefaultValue: 0m);
        }
    }
}
