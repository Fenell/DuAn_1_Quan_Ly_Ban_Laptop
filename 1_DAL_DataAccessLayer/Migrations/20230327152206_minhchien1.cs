using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL_DataAccessLayer.Migrations
{
    public partial class minhchien1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SerialLaptop_Laptop_IdSanPhamLaptop",
                table: "SerialLaptop");

            migrationBuilder.DropForeignKey(
                name: "FK_SerialLinhKien_LinhKien_IdSanPhamLinhKien",
                table: "SerialLinhKien");

            migrationBuilder.DropIndex(
                name: "IX_SerialLinhKien_IdSanPhamLinhKien",
                table: "SerialLinhKien");

            migrationBuilder.DropIndex(
                name: "IX_SerialLaptop_IdSanPhamLaptop",
                table: "SerialLaptop");

            migrationBuilder.DropColumn(
                name: "TonKho",
                table: "LinhKien");

            migrationBuilder.DropColumn(
                name: "TonKho",
                table: "Laptop");

            migrationBuilder.RenameColumn(
                name: "IdSanPhamLinhKien",
                table: "SerialLinhKien",
                newName: "IdLinhKien");

            migrationBuilder.RenameColumn(
                name: "IdSanPhamLaptop",
                table: "SerialLaptop",
                newName: "IdLaptop");

            migrationBuilder.AddColumn<int>(
                name: "DungLuong",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "HoaDon",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateIndex(
                name: "IX_SerialLinhKien_IdLinhKien",
                table: "SerialLinhKien",
                column: "IdLinhKien",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SerialLaptop_IdLaptop",
                table: "SerialLaptop",
                column: "IdLaptop",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SerialLaptop_Laptop_IdLaptop",
                table: "SerialLaptop",
                column: "IdLaptop",
                principalTable: "Laptop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SerialLinhKien_LinhKien_IdLinhKien",
                table: "SerialLinhKien",
                column: "IdLinhKien",
                principalTable: "LinhKien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SerialLaptop_Laptop_IdLaptop",
                table: "SerialLaptop");

            migrationBuilder.DropForeignKey(
                name: "FK_SerialLinhKien_LinhKien_IdLinhKien",
                table: "SerialLinhKien");

            migrationBuilder.DropIndex(
                name: "IX_SerialLinhKien_IdLinhKien",
                table: "SerialLinhKien");

            migrationBuilder.DropIndex(
                name: "IX_SerialLaptop_IdLaptop",
                table: "SerialLaptop");

            migrationBuilder.DropColumn(
                name: "DungLuong",
                table: "RAM");

            migrationBuilder.RenameColumn(
                name: "IdLinhKien",
                table: "SerialLinhKien",
                newName: "IdSanPhamLinhKien");

            migrationBuilder.RenameColumn(
                name: "IdLaptop",
                table: "SerialLaptop",
                newName: "IdSanPhamLaptop");

            migrationBuilder.AddColumn<int>(
                name: "TonKho",
                table: "LinhKien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TonKho",
                table: "Laptop",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "TrangThai",
                table: "HoaDon",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_SerialLinhKien_IdSanPhamLinhKien",
                table: "SerialLinhKien",
                column: "IdSanPhamLinhKien");

            migrationBuilder.CreateIndex(
                name: "IX_SerialLaptop_IdSanPhamLaptop",
                table: "SerialLaptop",
                column: "IdSanPhamLaptop");

            migrationBuilder.AddForeignKey(
                name: "FK_SerialLaptop_Laptop_IdSanPhamLaptop",
                table: "SerialLaptop",
                column: "IdSanPhamLaptop",
                principalTable: "Laptop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SerialLinhKien_LinhKien_IdSanPhamLinhKien",
                table: "SerialLinhKien",
                column: "IdSanPhamLinhKien",
                principalTable: "LinhKien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
