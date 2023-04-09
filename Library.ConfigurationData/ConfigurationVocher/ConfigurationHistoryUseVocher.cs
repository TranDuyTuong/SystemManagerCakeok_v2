using Library.DataTable.TableUser;
using Library.DataTable.TableVocher;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationVocher
{
    public class ConfigurationHistoryUseVocher : IEntityTypeConfiguration<T_HistoryUseVocher>
    {
        public void Configure(EntityTypeBuilder<T_HistoryUseVocher> builder)
        {
            builder.ToTable("T_HistoryUseVochers");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.IDUser).IsRequired();
            builder.Property(x => x.IDVocher).IsRequired();

            builder.HasOne<T_Customer>().WithMany().HasPrincipalKey(x => x.IDUser)
                                    .HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Vocher>().WithMany().HasPrincipalKey(x => x.IDVocher)
                                    .HasForeignKey(x => x.IDVocher).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
