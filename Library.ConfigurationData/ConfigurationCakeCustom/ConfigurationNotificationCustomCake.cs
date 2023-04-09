using Library.DataTable.TableCakeCustom;
using Library.DataTable.TableUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationCakeCustom
{
    public class ConfigurationNotificationCustomCake : IEntityTypeConfiguration<T_NotificationCustomCake>
    {
        public void Configure(EntityTypeBuilder<T_NotificationCustomCake> builder)
        {
            builder.ToTable("T_NotificationCustomCakes");
            builder.HasKey(x => x.IDNotification);
            builder.Property(x => x.IDNotification).ValueGeneratedOnAdd();
            builder.Property(x => x.Content).IsRequired().HasColumnType("nvarchar(450)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.IDIdea).IsRequired();
            builder.Property(x => x.IDUser).IsRequired();

            builder.HasOne<T_CakeCustomIdea>().WithMany().HasPrincipalKey(x => x.IDIdea)
                                    .HasForeignKey(x => x.IDIdea).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Customer>().WithMany().HasPrincipalKey(x => x.IDUser)
                                    .HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
