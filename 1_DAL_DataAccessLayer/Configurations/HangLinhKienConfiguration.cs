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
    public class HangLinhKienConfiguration:IEntityTypeConfiguration<HangLinhKien>
    {
        public void Configure(EntityTypeBuilder<HangLinhKien> builder)
        {
            builder.ToTable("HangLinhKien");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ten).HasMaxLength(50).IsRequired();
            builder.Property(x=>x.Ma).HasMaxLength(10).IsRequired();

            builder.HasMany<LoaiLinhKien>(x => x.LoaiLinhKiens).WithOne(a => a.HangLinhKien)
                .HasForeignKey(a => a.IdHangLinhKien);
        }
    }
}
