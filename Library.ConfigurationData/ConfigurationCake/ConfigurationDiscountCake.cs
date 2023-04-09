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
    public class ConfigurationDiscountCake : IEntityTypeConfiguration<T_DiscountCake>
    {
        public void Configure(EntityTypeBuilder<T_DiscountCake> builder)
        {
            builder.ToTable("T_DiscountCakes");
            builder.HasKey(x => x.IDDiscount);
            builder.Property(x => x.IDDiscount).ValueGeneratedOnAdd();
            builder.Property(x => x.PercentReduction).IsRequired();
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.NameDiscount).IsRequired();
        }
    }
}
