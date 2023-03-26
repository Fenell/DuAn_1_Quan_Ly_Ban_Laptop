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
    public class SerialLinhKienConfiguration:IEntityTypeConfiguration<SerialLinhKien>
    {
        public void Configure(EntityTypeBuilder<SerialLinhKien> builder)
        {
            builder.ToTable("SerialLinhKien");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Serial).HasMaxLength(50).IsRequired();
        }
    }
}
