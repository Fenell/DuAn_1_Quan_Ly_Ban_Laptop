﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL_DataAccessLayer.Migrations
{
<<<<<<< HEAD
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230330162642_chienco.cs
    public partial class chienco : Migration
=======
    public partial class tuanlong : Migration
>>>>>>> update chức năng nhân viên (Thiếu tìm kiếm):1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
=======
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
    public partial class tuanlong : Migration
=======
    public partial class updatedbN : Migration
>>>>>>> Update db lần thứ n+1:1_DAL_DataAccessLayer/Migrations/20230328082325_updatedbN.cs
>>>>>>> Update db lần thứ n+1
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CPU",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HangLaptop",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangLaptop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Hoten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LoaiKhuyenMai = table.Column<string>(type: "nvarchar(max)", nullable: false),
<<<<<<< HEAD
                    GiaTri = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
=======
                    GiaTri = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
>>>>>>> Update db lần thứ n+1
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManHinh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManHinh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGuiBaoCao = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Hoten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CCCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_NhanVien_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OCung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Loai = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    DungLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCung", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RAM",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DungLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VGA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VGA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DongLaptop",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdHangLaptop = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongLaptop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DongLaptop_HangLaptop_IdHangLaptop",
                        column: x => x.IdHangLaptop,
                        principalTable: "HangLaptop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HinhThucTT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    DiaChiNhanHang = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,0)", nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLaptop = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdLinhKien = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DonGia = table.Column<decimal>(type: "decimal(18,0)", nullable: false, defaultValue: 0m),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,0)", nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Laptop",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHangLaptop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDongLaptop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhaCungCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCpu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVga = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdRam = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdManHinh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdOCung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
<<<<<<< HEAD
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230330162642_chienco.cs
                    IdKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
=======
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TonKho = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
>>>>>>> update chức năng nhân viên (Thiếu tìm kiếm):1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
=======
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
=======
                    IdKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
>>>>>>> Update db lần thứ n+1:1_DAL_DataAccessLayer/Migrations/20230328082325_updatedbN.cs
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
>>>>>>> Update db lần thứ n+1
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrongLuong = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    NamBh = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    HinhAnh = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SerialLaptopId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laptop_CPU_IdCpu",
                        column: x => x.IdCpu,
                        principalTable: "CPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Laptop_DongLaptop_IdDongLaptop",
                        column: x => x.IdDongLaptop,
                        principalTable: "DongLaptop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Laptop_HangLaptop_IdHangLaptop",
                        column: x => x.IdHangLaptop,
                        principalTable: "HangLaptop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Laptop_KhuyenMai_IdKhuyenMai",
                        column: x => x.IdKhuyenMai,
                        principalTable: "KhuyenMai",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Laptop_ManHinh_IdManHinh",
                        column: x => x.IdManHinh,
                        principalTable: "ManHinh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Laptop_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Laptop_NhaCungCap_IdNhaCungCap",
                        column: x => x.IdNhaCungCap,
                        principalTable: "NhaCungCap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Laptop_OCung_IdOCung",
                        column: x => x.IdOCung,
                        principalTable: "OCung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Laptop_RAM_IdRam",
                        column: x => x.IdRam,
                        principalTable: "RAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Laptop_VGA_IdVga",
                        column: x => x.IdVga,
                        principalTable: "VGA",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230330162642_chienco.cs
=======
                name: "LinhKien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoaiLinhKien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHangLinhKien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhaCungCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MoTaChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    NamBH = table.Column<int>(type: "int", nullable: false),
                    HinhAnh = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhKien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinhKien_HangLinhKien_IdHangLinhKien",
                        column: x => x.IdHangLinhKien,
                        principalTable: "HangLinhKien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinhKien_KhuyenMai_IdKhuyenMai",
                        column: x => x.IdKhuyenMai,
                        principalTable: "KhuyenMai",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinhKien_LoaiLinhKien_IdLoaiLinhKien",
                        column: x => x.IdLoaiLinhKien,
                        principalTable: "LoaiLinhKien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LinhKien_NhaCungCap_IdNhaCungCap",
                        column: x => x.IdNhaCungCap,
                        principalTable: "NhaCungCap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
>>>>>>> update chức năng nhân viên (Thiếu tìm kiếm):1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
                name: "SerialLaptop",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
<<<<<<< HEAD
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230330162642_chienco.cs
                    IdLaptop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
=======
                    IdSanPhamLaptop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
>>>>>>> update chức năng nhân viên (Thiếu tìm kiếm):1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
=======
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
                    IdSanPhamLaptop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
=======
                    IdLaptop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
>>>>>>> Update db lần thứ n+1:1_DAL_DataAccessLayer/Migrations/20230328082325_updatedbN.cs
>>>>>>> Update db lần thứ n+1
                    Serial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialLaptop", x => x.Id);
                    table.ForeignKey(
<<<<<<< HEAD
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230330162642_chienco.cs
                        name: "FK_SerialLaptop_Laptop_IdLaptop",
                        column: x => x.IdLaptop,
=======
                        name: "FK_SerialLaptop_Laptop_IdSanPhamLaptop",
                        column: x => x.IdSanPhamLaptop,
>>>>>>> update chức năng nhân viên (Thiếu tìm kiếm):1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
=======
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
                        name: "FK_SerialLaptop_Laptop_IdSanPhamLaptop",
                        column: x => x.IdSanPhamLaptop,
=======
                        name: "FK_SerialLaptop_Laptop_IdLaptop",
                        column: x => x.IdLaptop,
>>>>>>> Update db lần thứ n+1:1_DAL_DataAccessLayer/Migrations/20230328082325_updatedbN.cs
>>>>>>> Update db lần thứ n+1
                        principalTable: "Laptop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230330162642_chienco.cs
=======
            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLaptop = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdLinhKien = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DonGia = table.Column<decimal>(type: "decimal(18,4)", nullable: false, defaultValue: 0m),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,4)", nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_Laptop_IdLaptop",
                        column: x => x.IdLaptop,
                        principalTable: "Laptop",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_LinhKien_IdLinhKien",
                        column: x => x.IdLinhKien,
                        principalTable: "LinhKien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
                name: "ChiTietKhuyenMai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLinhKien = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdLaptop = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietKhuyenMai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietKhuyenMai_KhuyenMai_IdKhuyenMai",
                        column: x => x.IdKhuyenMai,
                        principalTable: "KhuyenMai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietKhuyenMai_Laptop_IdLaptop",
                        column: x => x.IdLaptop,
                        principalTable: "Laptop",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChiTietKhuyenMai_LinhKien_IdLinhKien",
                        column: x => x.IdLinhKien,
                        principalTable: "LinhKien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
=======
>>>>>>> Update db lần thứ n+1:1_DAL_DataAccessLayer/Migrations/20230328082325_updatedbN.cs
                name: "SerialLinhKien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
                    IdSanPhamLinhKien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
=======
                    IdLinhKien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
>>>>>>> Update db lần thứ n+1:1_DAL_DataAccessLayer/Migrations/20230328082325_updatedbN.cs
                    Serial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialLinhKien", x => x.Id);
                    table.ForeignKey(
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
                        name: "FK_SerialLinhKien_LinhKien_IdSanPhamLinhKien",
                        column: x => x.IdSanPhamLinhKien,
=======
                        name: "FK_SerialLinhKien_LinhKien_IdLinhKien",
                        column: x => x.IdLinhKien,
>>>>>>> Update db lần thứ n+1:1_DAL_DataAccessLayer/Migrations/20230328082325_updatedbN.cs
                        principalTable: "LinhKien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

>>>>>>> update chức năng nhân viên (Thiếu tìm kiếm):1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_IdHoaDon",
                table: "ChiTietHoaDon",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_IdLaptop",
                table: "ChiTietHoaDon",
                column: "IdLaptop");

            migrationBuilder.CreateIndex(
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230330162642_chienco.cs
=======
                name: "IX_ChiTietHoaDon_IdLinhKien",
                table: "ChiTietHoaDon",
                column: "IdLinhKien");

            migrationBuilder.CreateIndex(
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
                name: "IX_ChiTietKhuyenMai_IdKhuyenMai",
                table: "ChiTietKhuyenMai",
                column: "IdKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKhuyenMai_IdLaptop",
                table: "ChiTietKhuyenMai",
                column: "IdLaptop");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKhuyenMai_IdLinhKien",
                table: "ChiTietKhuyenMai",
                column: "IdLinhKien");

            migrationBuilder.CreateIndex(
<<<<<<< HEAD
>>>>>>> update chức năng nhân viên (Thiếu tìm kiếm):1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
=======
=======
>>>>>>> Update db lần thứ n+1:1_DAL_DataAccessLayer/Migrations/20230328082325_updatedbN.cs
>>>>>>> Update db lần thứ n+1
                name: "IX_DongLaptop_IdHangLaptop",
                table: "DongLaptop",
                column: "IdHangLaptop");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_IdCpu",
                table: "Laptop",
                column: "IdCpu");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_IdDongLaptop",
                table: "Laptop",
                column: "IdDongLaptop");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_IdHangLaptop",
                table: "Laptop",
                column: "IdHangLaptop");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_IdKhuyenMai",
                table: "Laptop",
                column: "IdKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_IdManHinh",
                table: "Laptop",
                column: "IdManHinh");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_IdMauSac",
                table: "Laptop",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_IdNhaCungCap",
                table: "Laptop",
                column: "IdNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_IdOCung",
                table: "Laptop",
                column: "IdOCung");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_IdRam",
                table: "Laptop",
                column: "IdRam");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_IdVga",
                table: "Laptop",
                column: "IdVga");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_SerialLaptopId",
                table: "Laptop",
                column: "SerialLaptopId");

            migrationBuilder.CreateIndex(
<<<<<<< HEAD
                name: "IX_NhanVien_NhanVienId",
                table: "NhanVien",
                column: "NhanVienId");
=======
                name: "IX_LinhKien_IdKhuyenMai",
                table: "LinhKien",
                column: "IdKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_LinhKien_IdLoaiLinhKien",
                table: "LinhKien",
                column: "IdLoaiLinhKien");
>>>>>>> Update db lần thứ n+1

            migrationBuilder.CreateIndex(
                name: "IX_SerialLaptop_IdLaptop",
                table: "SerialLaptop",
                column: "IdLaptop");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_Laptop_IdLaptop",
                table: "ChiTietHoaDon",
                column: "IdLaptop",
                principalTable: "Laptop",
                principalColumn: "Id");

<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230330162642_chienco.cs
            migrationBuilder.AddForeignKey(
                name: "FK_Laptop_SerialLaptop_SerialLaptopId",
                table: "Laptop",
                column: "SerialLaptopId",
                principalTable: "SerialLaptop",
                principalColumn: "Id");
=======
            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_NhanVienId",
                table: "NhanVien",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
                name: "IX_SerialLaptop_IdSanPhamLaptop",
                table: "SerialLaptop",
                column: "IdSanPhamLaptop");

            migrationBuilder.CreateIndex(
                name: "IX_SerialLinhKien_IdSanPhamLinhKien",
                table: "SerialLinhKien",
                column: "IdSanPhamLinhKien");
<<<<<<< HEAD
>>>>>>> update chức năng nhân viên (Thiếu tìm kiếm):1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
=======
=======
                name: "IX_SerialLaptop_IdLaptop",
                table: "SerialLaptop",
                column: "IdLaptop",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SerialLinhKien_IdLinhKien",
                table: "SerialLinhKien",
                column: "IdLinhKien",
                unique: true);
>>>>>>> Update db lần thứ n+1:1_DAL_DataAccessLayer/Migrations/20230328082325_updatedbN.cs
>>>>>>> Update db lần thứ n+1
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
<<<<<<< HEAD
            migrationBuilder.DropForeignKey(
                name: "FK_SerialLaptop_Laptop_IdLaptop",
                table: "SerialLaptop");

            migrationBuilder.DropTable(
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230330162642_chienco.cs
                name: "ChiTietHoaDon");
=======
=======
            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "SerialLaptop");

            migrationBuilder.DropTable(
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs
>>>>>>> Update db lần thứ n+1
                name: "SerialLaptop");

            migrationBuilder.DropTable(
=======
>>>>>>> Update db lần thứ n+1:1_DAL_DataAccessLayer/Migrations/20230328082325_updatedbN.cs
                name: "SerialLinhKien");
>>>>>>> update chức năng nhân viên (Thiếu tìm kiếm):1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
<<<<<<< HEAD
=======
                name: "Laptop");

            migrationBuilder.DropTable(
                name: "LinhKien");

            migrationBuilder.DropTable(
>>>>>>> Update db lần thứ n+1
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Laptop");

            migrationBuilder.DropTable(
                name: "CPU");

            migrationBuilder.DropTable(
                name: "DongLaptop");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "ManHinh");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "OCung");

            migrationBuilder.DropTable(
                name: "RAM");

            migrationBuilder.DropTable(
<<<<<<< HEAD
                name: "SerialLaptop");
=======
                name: "VGA");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "LoaiLinhKien");
>>>>>>> Update db lần thứ n+1

            migrationBuilder.DropTable(
<<<<<<< HEAD:1_DAL_DataAccessLayer/Migrations/20230330162642_chienco.cs
                name: "VGA");
=======
                name: "NhaCungCap");
>>>>>>> update chức năng nhân viên (Thiếu tìm kiếm):1_DAL_DataAccessLayer/Migrations/20230327075200_tuanlong.cs

            migrationBuilder.DropTable(
                name: "HangLaptop");
        }
    }
}
