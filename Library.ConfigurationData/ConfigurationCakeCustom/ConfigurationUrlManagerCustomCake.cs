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
    public class ConfigurationUrlManagerCustomCake : IEntityTypeConfiguration<T_UrlManagerCustomCake>
    {
        public void Configure(EntityTypeBuilder<T_UrlManagerCustomCake> builder)
        {
            builder.ToTable("T_UrlManagerCustomCakes");
            builder.HasKey(x => x.IDUrl);
            builder.Property(x => x.Url).IsRequired();
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
