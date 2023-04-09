using Library.DataTable.TableInformationAuthor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationInfomationAuthor
{
    public class ConfigurationInformationAuthor : IEntityTypeConfiguration<T_InformationAuthor>
    {
        public void Configure(EntityTypeBuilder<T_InformationAuthor> builder)
        {
            builder.ToTable("T_InformationAuthors");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(200).HasColumnType("nvarchar(200)");
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.ContentImage).IsRequired();
            builder.Property(x => x.NameImage).IsRequired();
            builder.Property(x => x.MimeType).IsRequired();
            builder.Property(x => x.TypeFile).IsRequired().HasMaxLength(20);
            builder.Property(x => x.IDPosition).IsRequired();

            builder.HasOne<T_Position>().WithMany().HasPrincipalKey(x => x.IDPosition)
                                    .HasForeignKey(x => x.IDPosition).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
