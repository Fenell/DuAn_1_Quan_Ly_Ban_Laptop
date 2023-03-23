using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL_DataAccessLayer.Migrations
{
    public partial class update_Db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LinhKien_NhaCungCapLk_IdNhaCungCap",
                table: "LinhKien");

            migrationBuilder.DropTable(
                name: "ChiTietLaptop");

            migrationBuilder.DropTable(
                name: "ChiTietLinhKien");

            migrationBuilder.DropTable(
                name: "NhaCungCapLk");

            migrationBuilder.AlterColumn<string>(
                name: "Ten",
                table: "VGA",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<bool>(
                name: "GioiTinh",
                table: "NhanVien",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "NhanVien",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_LinhKien_NhaCungCap_IdNhaCungCap",
                table: "LinhKien",
                column: "IdNhaCungCap",
                principalTable: "NhaCungCap",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LinhKien_NhaCungCap_IdNhaCungCap",
                table: "LinhKien");

            migrationBuilder.DropColumn(
                name: "GioiTinh",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "NhanVien");

            migrationBuilder.AlterColumn<string>(
                name: "Ten",
                table: "VGA",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateTable(
                name: "ChiTietLaptop",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLaptop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Imei = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietLaptop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietLaptop_Laptop_IdLaptop",
                        column: x => x.IdLaptop,
                        principalTable: "Laptop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietLinhKien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLinhKien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Seri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietLinhKien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietLinhKien_LinhKien_IdLinhKien",
                        column: x => x.IdLinhKien,
                        principalTable: "LinhKien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCapLk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCapLk", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietLaptop_IdLaptop",
                table: "ChiTietLaptop",
                column: "IdLaptop");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietLaptop_Imei",
                table: "ChiTietLaptop",
                column: "Imei",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietLinhKien_IdLinhKien",
                table: "ChiTietLinhKien",
                column: "IdLinhKien");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietLinhKien_Seri",
                table: "ChiTietLinhKien",
                column: "Seri",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LinhKien_NhaCungCapLk_IdNhaCungCap",
                table: "LinhKien",
                column: "IdNhaCungCap",
                principalTable: "NhaCungCapLk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
