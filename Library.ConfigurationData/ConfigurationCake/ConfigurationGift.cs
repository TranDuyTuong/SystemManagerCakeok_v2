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
    public class ConfigurationGift : IEntityTypeConfiguration<T_Gift>
    {
        public void Configure(EntityTypeBuilder<T_Gift> builder)
        {
            builder.ToTable("T_Gifts");
            builder.HasKey(x => x.IDGift);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(250).HasColumnType("nvarchar(250)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.NameImage).IsRequired();
            builder.Property(x => x.MimeType).IsRequired();
            builder.Property(x => x.TypeFile).IsRequired();
        }
    }
}
