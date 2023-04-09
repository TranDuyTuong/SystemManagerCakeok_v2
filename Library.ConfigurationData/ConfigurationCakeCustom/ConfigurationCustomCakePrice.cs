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
    public class ConfigurationCustomCakePrice : IEntityTypeConfiguration<T_CustomCakePrice>
    {
        public void Configure(EntityTypeBuilder<T_CustomCakePrice> builder)
        {
            builder.ToTable("T_CustomCakePrices");
            builder.HasKey(x => x.IDPriceCustom);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.IDCustom).IsRequired();

            builder.HasOne<T_CustomCake>().WithMany().HasPrincipalKey(x => x.IDCustom)
                                    .HasForeignKey(x => x.IDCustom).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
