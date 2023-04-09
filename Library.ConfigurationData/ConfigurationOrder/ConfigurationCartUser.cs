using Library.DataTable.TableCake;
using Library.DataTable.TableOrder;
using Library.DataTable.TableUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationOrder
{
    public class ConfigurationCartUser : IEntityTypeConfiguration<T_CartUser>
    {
        public void Configure(EntityTypeBuilder<T_CartUser> builder)
        {
            builder.ToTable("T_CartUsers");
            builder.HasKey(x => x.IDCart);
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.IDUser).IsRequired();
            builder.Property(x => x.IDCake).IsRequired();

            builder.HasOne<T_Customer>().WithMany().HasPrincipalKey(x => x.IDUser)
                                    .HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Cake>().WithMany().HasPrincipalKey(x => x.IDCake)
                                    .HasForeignKey(x => x.IDCake).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
