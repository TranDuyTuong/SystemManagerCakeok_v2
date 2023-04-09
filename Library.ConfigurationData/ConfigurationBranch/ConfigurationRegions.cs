using Library.DataTable.TableBranch;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationBranch
{
    public class ConfigurationRegions : IEntityTypeConfiguration<T_Regions>
    {
        public void Configure(EntityTypeBuilder<T_Regions> builder)
        {
            builder.ToTable("T_Regiones");
            builder.HasKey(x => x.IDRegion);
            builder.Property(x => x.IDRegion).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(250).HasColumnType("nvarchar(250)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
