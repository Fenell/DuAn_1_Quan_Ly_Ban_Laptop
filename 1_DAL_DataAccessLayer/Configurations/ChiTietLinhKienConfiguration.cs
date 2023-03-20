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
    public class ChiTietLinhKienConfiguration:IEntityTypeConfiguration<ChiTietLinhKien>
    {
        public void Configure(EntityTypeBuilder<ChiTietLinhKien> builder)
        {
            builder.ToTable("ChiTietLinhKien");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Seri).IsUnique();
            builder.Property(x => x.Seri).HasMaxLength(50);
        }
    }
}
