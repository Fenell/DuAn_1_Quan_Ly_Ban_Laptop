﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using _1_DAL_DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1_DAL_DataAccessLayer.Configurations
{
    public class HoaDonConfiguration: IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Ma).IsRequired();
            builder.Property(x => x.Ma).HasMaxLength(10);
            builder.Property(x=>x.NgayTao).IsRequired();
            builder.Property(x => x.TongTien).HasDefaultValue(0).HasColumnType("decimal(18,4)");
            builder.Property(x => x.GhiChu).HasMaxLength(200);
            builder.Property(x => x.DiaChiNhanHang).HasMaxLength(200);
            builder.Property(x => x.IdNhanVien).IsRequired();

            builder.HasOne<NhanVien>(x => x.NhanVien).WithMany(a => a.HoaDons).HasForeignKey(a => a.IdNhanVien);
            builder.HasOne<KhachHang>(X => X.KhachHang).WithMany(a => a.HoaDons).HasForeignKey(a => a.IdKhachHang);
        }
    }
}
