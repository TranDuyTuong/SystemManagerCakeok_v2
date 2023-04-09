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
    public class ConfigurationStatusCustomCake : IEntityTypeConfiguration<T_StatusCustomCake>
    {
        public void Configure(EntityTypeBuilder<T_StatusCustomCake> builder)
        {
            builder.ToTable("T_StatusCustomCakes");
            builder.HasKey(x => x.IDStatus);
            builder.Property(x => x.IDStatus).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(250)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
        }
    }
}
