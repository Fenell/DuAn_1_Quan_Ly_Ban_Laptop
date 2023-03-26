using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1_DAL_DataAccessLayer.Configurations
{
    public class ChiTietKhuyenMaiConfiguration:IEntityTypeConfiguration<ChiTietKhuyenMai>
    {
        public void Configure(EntityTypeBuilder<ChiTietKhuyenMai> builder)
        {
            builder.ToTable("ChiTietKhuyenMai");
            builder.HasKey(t => t.Id);
            builder.HasOne<KhuyenMai>(x => x.KhuyenMai).WithMany(a => a.ChiTietKhuyenMais)
                .HasForeignKey(a => a.IdKhuyenMai);
            builder.HasOne<SanPhamLaptop>(x => x.Laptop).WithMany(a => a.ChiTietKhuyenMais).HasForeignKey(a => a.IdLaptop);
            builder.HasOne<SanPhamLinhKien>(x => x.LinhKien).WithMany(a => a.ChiTietKhuyenMais)
                .HasForeignKey(a => a.IdLinhKien);
        }
    }
}
