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
    public class ChiTietLaptopConfiguration:IEntityTypeConfiguration<ChiTietLaptop>
    {
        public void Configure(EntityTypeBuilder<ChiTietLaptop> builder)
        {
            builder.ToTable("ChiTietLaptop");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Imei).IsUnique();
            builder.Property(x => x.IdLaptop).IsRequired();
            builder.Property(x => x.Imei).HasMaxLength(15).IsRequired();
        }
    }
}
