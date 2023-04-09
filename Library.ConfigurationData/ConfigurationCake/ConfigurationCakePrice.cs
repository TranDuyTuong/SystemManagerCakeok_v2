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
    public class ConfigurationCakePrice : IEntityTypeConfiguration<T_CakePrice>
    {
        public void Configure(EntityTypeBuilder<T_CakePrice> builder)
        {
            builder.ToTable("T_CakePrices");
            builder.HasKey(x => x.IDPrice);
            builder.Property(x => x.Price).IsRequired();

        }
    }
}
