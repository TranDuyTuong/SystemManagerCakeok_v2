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
    public class ConfigurationCakeGift : IEntityTypeConfiguration<T_CakeGift>
    {
        public void Configure(EntityTypeBuilder<T_CakeGift> builder)
        {
            builder.ToTable("T_CakeGifts");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.IDCake).IsRequired();
            builder.Property(x => x.IDGift).IsRequired();
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();

            builder.HasOne<T_Cake>().WithMany().HasPrincipalKey(x => x.IDCake)
                                        .HasForeignKey(x => x.IDCake).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Gift>().WithMany().HasPrincipalKey(x => x.IDGift)
                                        .HasForeignKey(x => x.IDGift).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
