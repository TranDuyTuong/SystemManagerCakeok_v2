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
    public class ConfigurationImageCustomIdea : IEntityTypeConfiguration<T_ImageCustomIdea>
    {
        public void Configure(EntityTypeBuilder<T_ImageCustomIdea> builder)
        {
            builder.ToTable("T_ImageCustomIdeas");
            builder.HasKey(x => x.IDImageCustom);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.TypeImage).IsRequired().HasMaxLength(10);
            builder.Property(x => x.MimeType).IsRequired();
            builder.Property(x => x.FileContent).IsRequired();
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.IDIdea).IsRequired();

            builder.HasOne<T_CakeCustomIdea>().WithMany().HasPrincipalKey(x => x.IDIdea)
                                    .HasForeignKey(x => x.IDIdea).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
