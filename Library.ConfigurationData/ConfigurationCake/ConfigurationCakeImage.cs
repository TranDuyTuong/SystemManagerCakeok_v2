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
    public class ConfigurationCakeImage : IEntityTypeConfiguration<T_CakeImage>
    {
        public void Configure(EntityTypeBuilder<T_CakeImage> builder)
        {
            builder.ToTable("T_CakeImages");
            builder.HasKey(x => x.IDImage);
            builder.Property(x => x.NameImage).IsRequired().HasMaxLength(100);
            builder.Property(x => x.TypeImage).IsRequired().HasMaxLength(10);
            builder.Property(x => x.MimeType).IsRequired();
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.MainImage).IsRequired();
            builder.Property(x => x.IDCake).IsRequired();

            builder.HasOne<T_Cake>().WithMany().HasPrincipalKey(x => x.IDCake)
                                        .HasForeignKey(x => x.IDCake).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
