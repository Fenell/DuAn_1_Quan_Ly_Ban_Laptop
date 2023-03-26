﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL_DataAccessLayer.Context;

#nullable disable

namespace _1_DAL_DataAccessLayer.Migrations
{
    [DbContext(typeof(QlBanLaptopContext))]
    [Migration("20230326133411_minhchien")]
    partial class minhchien
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.ChiTietHoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,4)")
                        .HasDefaultValue(0m);

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdLaptop")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdLinhKien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<decimal>("ThanhTien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,4)")
                        .HasDefaultValue(0m);

                    b.HasKey("Id");

                    b.HasIndex("IdHoaDon");

                    b.HasIndex("IdLaptop");

                    b.HasIndex("IdLinhKien");

                    b.ToTable("ChiTietHoaDon", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.ChiTietKhuyenMai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhuyenMai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdLaptop")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdLinhKien")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdKhuyenMai");

                    b.HasIndex("IdLaptop");

                    b.HasIndex("IdLinhKien");

                    b.ToTable("ChiTietKhuyenMai", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.Cpu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CPU", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.DongLaptop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHangLaptop")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdHangLaptop");

                    b.ToTable("DongLaptop", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HangLaptop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("HangLaptop", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HangLinhKien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("HangLinhKien", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChiNhanHang")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("HinhThucTT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongTien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,4)")
                        .HasDefaultValue(0m);

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("Hoten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.KhuyenMai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaTri")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("LoaiKhuyenMai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("KhuyenMai", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.LoaiLinhKien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHangLinhKien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdHangLinhKien");

                    b.ToTable("LoaiLinhKien", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.ManHinh", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ManHinh", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MauSac", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.NhaCungCap", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("NhaCungCap", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("ChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<byte[]>("HinhAnh")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Hoten")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("IdGuiBaoCao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NhanVienId");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.OCung", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DungLuong")
                        .HasColumnType("int");

                    b.Property<string>("Loai")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("OCung", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.Ram", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RAM", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.SanPhamLaptop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal(18,4)");

                    b.Property<byte[]>("HinhAnh")
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("IdCpu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdDongLaptop")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHangLaptop")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdManHinh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhaCungCap")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdOCung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdRam")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdVga")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NamBh")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TonKho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<bool?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<decimal>("TrongLuong")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.HasIndex("IdCpu");

                    b.HasIndex("IdDongLaptop");

                    b.HasIndex("IdHangLaptop");

                    b.HasIndex("IdManHinh");

                    b.HasIndex("IdMauSac");

                    b.HasIndex("IdNhaCungCap");

                    b.HasIndex("IdOCung");

                    b.HasIndex("IdRam");

                    b.HasIndex("IdVga");

                    b.ToTable("Laptop", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.SanPhamLinhKien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal(18,4)");

                    b.Property<byte[]>("HinhAnh")
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("IdHangLinhKien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdLoaiLinhKien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhaCungCap")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTaChiTiet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NamBH")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TonKho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<bool?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("IdHangLinhKien");

                    b.HasIndex("IdLoaiLinhKien");

                    b.HasIndex("IdNhaCungCap");

                    b.ToTable("LinhKien", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.SerialLaptop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSanPhamLaptop")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Serial")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdSanPhamLaptop");

                    b.ToTable("SerialLaptop", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.SerialLinhKien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSanPhamLinhKien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Serial")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdSanPhamLinhKien");

                    b.ToTable("SerialLinhKien", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.Vga", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("VGA", (string)null);
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.ChiTietHoaDon", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.HoaDon", "HoaDon")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.SanPhamLaptop", "Laptop")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("IdLaptop");

                    b.HasOne("_1_DAL_DataAccessLayer.Models.SanPhamLinhKien", "LinhKien")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("IdLinhKien");

                    b.Navigation("HoaDon");

                    b.Navigation("Laptop");

                    b.Navigation("LinhKien");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.ChiTietKhuyenMai", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.KhuyenMai", "KhuyenMai")
                        .WithMany("ChiTietKhuyenMais")
                        .HasForeignKey("IdKhuyenMai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.SanPhamLaptop", "Laptop")
                        .WithMany("ChiTietKhuyenMais")
                        .HasForeignKey("IdLaptop");

                    b.HasOne("_1_DAL_DataAccessLayer.Models.SanPhamLinhKien", "LinhKien")
                        .WithMany("ChiTietKhuyenMais")
                        .HasForeignKey("IdLinhKien");

                    b.Navigation("KhuyenMai");

                    b.Navigation("Laptop");

                    b.Navigation("LinhKien");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.DongLaptop", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.HangLaptop", "HangLaptop")
                        .WithMany("DongLaptops")
                        .HasForeignKey("IdHangLaptop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HangLaptop");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HoaDon", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.LoaiLinhKien", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.HangLinhKien", "HangLinhKien")
                        .WithMany("LoaiLinhKiens")
                        .HasForeignKey("IdHangLinhKien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HangLinhKien");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.NhanVien", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.NhanVien", null)
                        .WithMany("NhanViens")
                        .HasForeignKey("NhanVienId");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.SanPhamLaptop", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.Cpu", "Cpu")
                        .WithMany("Laptops")
                        .HasForeignKey("IdCpu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.DongLaptop", "DongLaptop")
                        .WithMany("Laptops")
                        .HasForeignKey("IdDongLaptop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.HangLaptop", "HangLaptop")
                        .WithMany("Laptops")
                        .HasForeignKey("IdHangLaptop")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.ManHinh", "ManHinh")
                        .WithMany("Laptops")
                        .HasForeignKey("IdManHinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.MauSac", "MauSac")
                        .WithMany("Laptops")
                        .HasForeignKey("IdMauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.NhaCungCap", "NhaCungCap")
                        .WithMany("Laptops")
                        .HasForeignKey("IdNhaCungCap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.OCung", "OCung")
                        .WithMany("Laptops")
                        .HasForeignKey("IdOCung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.Ram", "Ram")
                        .WithMany("Laptops")
                        .HasForeignKey("IdRam")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.Vga", "Vga")
                        .WithMany("Laptops")
                        .HasForeignKey("IdVga");

                    b.Navigation("Cpu");

                    b.Navigation("DongLaptop");

                    b.Navigation("HangLaptop");

                    b.Navigation("ManHinh");

                    b.Navigation("MauSac");

                    b.Navigation("NhaCungCap");

                    b.Navigation("OCung");

                    b.Navigation("Ram");

                    b.Navigation("Vga");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.SanPhamLinhKien", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.HangLinhKien", "HangLinhKien")
                        .WithMany("LinhKiens")
                        .HasForeignKey("IdHangLinhKien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.LoaiLinhKien", "LoaiLinhKien")
                        .WithMany("LinhKiens")
                        .HasForeignKey("IdLoaiLinhKien")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("_1_DAL_DataAccessLayer.Models.NhaCungCap", "NhaCungCap")
                        .WithMany("LinhKiens")
                        .HasForeignKey("IdNhaCungCap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HangLinhKien");

                    b.Navigation("LoaiLinhKien");

                    b.Navigation("NhaCungCap");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.SerialLaptop", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.SanPhamLaptop", "SanPhamLaptop")
                        .WithMany("SerialLaptops")
                        .HasForeignKey("IdSanPhamLaptop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPhamLaptop");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.SerialLinhKien", b =>
                {
                    b.HasOne("_1_DAL_DataAccessLayer.Models.SanPhamLinhKien", "SanPhamLinhKien")
                        .WithMany("SerialLinhKiens")
                        .HasForeignKey("IdSanPhamLinhKien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPhamLinhKien");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.Cpu", b =>
                {
                    b.Navigation("Laptops");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.DongLaptop", b =>
                {
                    b.Navigation("Laptops");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HangLaptop", b =>
                {
                    b.Navigation("DongLaptops");

                    b.Navigation("Laptops");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HangLinhKien", b =>
                {
                    b.Navigation("LinhKiens");

                    b.Navigation("LoaiLinhKiens");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.HoaDon", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.KhuyenMai", b =>
                {
                    b.Navigation("ChiTietKhuyenMais");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.LoaiLinhKien", b =>
                {
                    b.Navigation("LinhKiens");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.ManHinh", b =>
                {
                    b.Navigation("Laptops");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.MauSac", b =>
                {
                    b.Navigation("Laptops");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.NhaCungCap", b =>
                {
                    b.Navigation("Laptops");

                    b.Navigation("LinhKiens");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDons");

                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.OCung", b =>
                {
                    b.Navigation("Laptops");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.Ram", b =>
                {
                    b.Navigation("Laptops");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.SanPhamLaptop", b =>
                {
                    b.Navigation("ChiTietHoaDons");

                    b.Navigation("ChiTietKhuyenMais");

                    b.Navigation("SerialLaptops");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.SanPhamLinhKien", b =>
                {
                    b.Navigation("ChiTietHoaDons");

                    b.Navigation("ChiTietKhuyenMais");

                    b.Navigation("SerialLinhKiens");
                });

            modelBuilder.Entity("_1_DAL_DataAccessLayer.Models.Vga", b =>
                {
                    b.Navigation("Laptops");
                });
#pragma warning restore 612, 618
        }
    }
}
