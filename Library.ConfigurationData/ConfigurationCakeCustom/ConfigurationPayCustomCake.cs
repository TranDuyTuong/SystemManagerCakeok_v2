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
    public class ConfigurationPayCustomCake : IEntityTypeConfiguration<T_PayCustomCake>
    {
        public void Configure(EntityTypeBuilder<T_PayCustomCake> builder)
        {
            builder.ToTable("T_PayCustomCakes");
            builder.HasKey(x => x.IDPay);
            builder.Property(x => x.IDPay).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(250).HasColumnType("nvarchar(250)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
        }
    }
}
