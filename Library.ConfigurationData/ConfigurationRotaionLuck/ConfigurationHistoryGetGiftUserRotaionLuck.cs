using Library.DataTable.TableRotationLuck;
using Library.DataTable.TableUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationRotaionLuck
{
    public class ConfigurationHistoryGetGiftUserRotaionLuck : IEntityTypeConfiguration<T_HistoryGetGiftUserRotaionLuck>
    {
        public void Configure(EntityTypeBuilder<T_HistoryGetGiftUserRotaionLuck> builder)
        {
            builder.ToTable("T_HistoryGetGiftUserRotaionLucks");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.IDLuck).IsRequired();
            builder.Property(x => x.IDUser).IsRequired();

            builder.HasOne<T_GiftLuck>().WithMany().HasPrincipalKey(x => x.IDLuck)
                                    .HasForeignKey(x => x.IDLuck).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Customer>().WithMany().HasPrincipalKey(x => x.IDUser)
                                    .HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
