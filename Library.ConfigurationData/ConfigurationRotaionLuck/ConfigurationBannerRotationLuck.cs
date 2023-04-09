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
    public class ConfigurationBannerRotationLuck : IEntityTypeConfiguration<T_BannerRotationLuck>
    {
        public void Configure(EntityTypeBuilder<T_BannerRotationLuck> builder)
        {
            builder.ToTable("T_BannerRotationLucks");
            builder.HasKey(x => x.IDBackRound);
            builder.Property(x => x.IDBackRound).ValueGeneratedOnAdd();
            builder.Property(x => x.NameImage).IsRequired();
            builder.Property(x => x.ContentFile).IsRequired();
            builder.Property(x => x.MimeType).IsRequired();
            builder.Property(x => x.TypeFile).IsRequired().HasMaxLength(20);
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
