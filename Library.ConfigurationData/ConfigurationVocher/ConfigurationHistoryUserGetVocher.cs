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
    public class ConfigurationHistoryUserGetVocher : IEntityTypeConfiguration<T_HistoryUserGetVocher>
    {
        public void Configure(EntityTypeBuilder<T_HistoryUserGetVocher> builder)
        {
            builder.ToTable("T_HistoryUserGetVochers");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Note).IsRequired().HasColumnType("nvarchar(250)");
            builder.Property(x => x.StatusUseVocher).IsRequired();
            builder.Property(x => x.IDUser).IsRequired();
            builder.Property(x => x.IDVocher).IsRequired();

            builder.HasOne(x => x.t_Customer).WithMany(x => x.t_HistoryUserGetVochers).HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_Vocher).WithMany(x => x.t_HistoryUserGetVocher).HasForeignKey(x => x.IDVocher).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
