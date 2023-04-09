using Library.DataTable.TableOrder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationOrder
{
    public class ConfigurationTypePay : IEntityTypeConfiguration<T_TypePay>
    {
        public void Configure(EntityTypeBuilder<T_TypePay> builder)
        {
            builder.ToTable("T_TypePays");
            builder.HasKey(x => x.IDPay);
            builder.Property(x => x.NamePay).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
