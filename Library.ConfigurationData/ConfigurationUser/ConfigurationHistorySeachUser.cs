using Library.DataTable.TableUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationUser
{
    public class ConfigurationHistorySeachUser : IEntityTypeConfiguration<T_HistorySeachUser>
    {
        public void Configure(EntityTypeBuilder<T_HistorySeachUser> builder)
        {
            builder.ToTable("T_HistorySeachUsers");
            builder.HasKey(x => x.IdSeach);
            builder.Property(x => x.SeachName).IsRequired().HasColumnType("nvarchar(400)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.IDUser).IsRequired();

            builder.HasOne<T_Customer>().WithMany().HasPrincipalKey(x => x.IDUser)
                                    .HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
