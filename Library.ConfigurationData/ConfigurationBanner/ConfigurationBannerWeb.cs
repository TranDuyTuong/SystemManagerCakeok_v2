using Library.DataTable.TableBanner;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationBanner
{
    public class ConfigurationBannerWeb : IEntityTypeConfiguration<T_ImageBannerWeb>
    {
        public void Configure(EntityTypeBuilder<T_ImageBannerWeb> builder)
        {
            builder.ToTable("T_ImageBannerWebs");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(200).HasColumnType("nvarchar(150)");
            builder.Property(x => x.ContentFile).IsRequired();
            builder.Property(x => x.MimeType).IsRequired();
            builder.Property(x => x.TypeImage).IsRequired().HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
