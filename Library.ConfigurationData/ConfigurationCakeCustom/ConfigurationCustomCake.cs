using Library.DataTable.TableCakeCustom;
using Library.DataTable.TableChef;
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
    public class ConfigurationCustomCake : IEntityTypeConfiguration<T_CustomCake>
    {
        public void Configure(EntityTypeBuilder<T_CustomCake> builder)
        {
            builder.ToTable("T_CustomCakes");
            builder.HasKey(x => x.IDCustom);
            builder.Property(x => x.NoCustom).IsRequired();
            builder.Property(x => x.NameCustom).IsRequired().HasColumnType("nvarchar(250)");
            builder.Property(x => x.BookingDate).IsRequired();
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.IDUser).IsRequired();
            builder.Property(x => x.IDStatus).IsRequired();
            builder.Property(x => x.IDPay).IsRequired();
            builder.Property(x => x.IDIdea).IsRequired();
            builder.Property(x => x.IDChef).IsRequired();

            builder.HasOne(x => x.t_Customer).WithMany(x => x.t_CustomCakes).HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_StatusCustomCake).WithMany(x => x.t_CustomCakes).HasForeignKey(x => x.IDStatus).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_PayCustomCake).WithMany(x => x.t_CustomCakes).HasForeignKey(x => x.IDPay).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_CakeCustomIdea).WithMany(x => x.t_CustomCakes).HasForeignKey(x => x.IDIdea).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_Chef).WithMany(x => x.t_CustomCakes).HasForeignKey(x => x.IDChef).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
