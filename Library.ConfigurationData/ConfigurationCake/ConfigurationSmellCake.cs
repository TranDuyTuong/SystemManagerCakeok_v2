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
    public class ConfigurationSmellCake : IEntityTypeConfiguration<T_SmellCake>
    {
        public void Configure(EntityTypeBuilder<T_SmellCake> builder)
        {
            builder.ToTable("T_SmellCakes");
            builder.HasKey(x => x.IDSmell);
            builder.Property(x => x.IDSmell).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(250).HasColumnType("nvarchar(250)");
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
        }
    }
}
