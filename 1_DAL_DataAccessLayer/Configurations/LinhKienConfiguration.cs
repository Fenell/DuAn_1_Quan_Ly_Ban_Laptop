using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1_DAL_DataAccessLayer.Configurations
{
    public class LinhKienConfiguration:IEntityTypeConfiguration<LinhKien>
    {
        public void Configure(EntityTypeBuilder<LinhKien> builder)
        {
            builder.ToTable("LinhKien");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ten).HasMaxLength(20).IsRequired();
            builder.Property(x => x.GiaBan).HasColumnType("decimal(18,4)").IsRequired();
            builder.Property(x => x.GiaNhap).HasColumnType("decimal(18,4)").IsRequired();
            builder.Property(x=>x.NamBH).IsRequired();
            builder.Property(x => x.TrangThai).HasDefaultValue(true);

            //builder.Property(x => x.IdHangLinhKien).IsRequired();
            //builder.Property(x => x.IdLoaiLinhKien).IsRequired();
            //builder.Property(x=>x.IdNhaCungCap).IsRequired();

            builder.HasOne<HangLinhKien>(x => x.HangLinhKien).WithMany(a => a.LinhKiens)
                .HasForeignKey(x => x.IdHangLinhKien);
            builder.HasOne<LoaiLinhKien>(x => x.LoaiLinhKien).WithMany(a => a.LinhKiens)
                .HasForeignKey(x => x.IdLoaiLinhKien).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<NhaCungCap>(x => x.NhaCungCap).WithMany(a => a.LinhKiens)
                .HasForeignKey(x => x.IdNhaCungCap);

            builder.HasOne<SerialLinhKien>(x => x.SerialLinhKien).WithOne(a => a.LinhKien)
                .HasForeignKey<SerialLinhKien>(a => a.IdLinhKien);

            builder.HasOne<KhuyenMai>(c => c.KhuyenMai).WithMany(a => a.LinhKiens).HasForeignKey(c => c.IdKhuyenMai);
        }
    }
}
