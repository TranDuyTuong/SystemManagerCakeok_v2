using Library.DataTable.TableCakeCustom;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationCakeCustom
{
    public class ConfigurationSizeCake : IEntityTypeConfiguration<T_SizeCake>
    {
        public void Configure(EntityTypeBuilder<T_SizeCake> builder)
        {
            builder.ToTable("T_SizeCakes");
            builder.HasKey(x => x.IDSize);
            builder.Property(x => x.IDSize).ValueGeneratedOnAdd();
            builder.Property(x => x.NameSize).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
        }
    }
}
