using Library.DataTable.TableRotationLuck;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationRotaionLuck
{
    public class ConfigurationGiftLuck : IEntityTypeConfiguration<T_GiftLuck>
    {
        public void Configure(EntityTypeBuilder<T_GiftLuck> builder)
        {
            builder.ToTable("T_GiftLucks");
            builder.HasKey(x => x.IDLuck);
            builder.Property(x => x.NameGift).IsRequired().HasMaxLength(200).HasColumnType("nvarchar(200)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.ContentImage).IsRequired();
            builder.Property(x => x.MimeType).IsRequired();
            builder.Property(x => x.NameImage).IsRequired();
            builder.Property(x => x.TypeFile).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
