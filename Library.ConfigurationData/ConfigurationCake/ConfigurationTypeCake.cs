using Library.DataTable.TableCake;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationCake
{
    public class ConfigurationTypeCake : IEntityTypeConfiguration<T_TypeCake>
    {
        public void Configure(EntityTypeBuilder<T_TypeCake> builder)
        {
            builder.ToTable("T_TypeCakes");
            builder.HasKey(x => x.IDTypeCake);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(250).HasColumnType("nvarchar(250)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
