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
    public class ConfigurationNewCake : IEntityTypeConfiguration<T_NewCake>
    {
        public void Configure(EntityTypeBuilder<T_NewCake> builder)
        {
            builder.ToTable("T_NewCakes");
            builder.HasKey(x => x.IDNewCake);
            builder.Property(x => x.IDNewCake).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(250).HasColumnType("nvarchar(250)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Status).IsRequired();

        }
    }
}
