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
    public class ConfigurationStatusCake : IEntityTypeConfiguration<T_StatusCake>
    {
        public void Configure(EntityTypeBuilder<T_StatusCake> builder)
        {
            builder.ToTable("T_StatusCakes");
            builder.HasKey(x => x.IDStatus);
            builder.Property(x => x.IDStatus).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(250).HasColumnType("nvarchar(250)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
        }
    }
}
