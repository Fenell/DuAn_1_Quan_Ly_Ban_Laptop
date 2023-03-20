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
    public class LoaiLinhKienConfiguration:IEntityTypeConfiguration<LoaiLinhKien>
    {
        public void Configure(EntityTypeBuilder<LoaiLinhKien> builder)
        {
            builder.ToTable("LoaiLinhKien");
            builder.HasKey(x => x.Id);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ten).HasMaxLength(50).IsRequired();
            builder.Property(x=>x.Ma).HasMaxLength(10).IsRequired();
        }
    }
}
