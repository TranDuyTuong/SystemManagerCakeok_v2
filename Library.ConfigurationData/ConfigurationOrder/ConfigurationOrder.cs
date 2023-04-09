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
    public class ConfigurationOrder : IEntityTypeConfiguration<T_Order>
    {
        public void Configure(EntityTypeBuilder<T_Order> builder)
        {
            builder.ToTable("T_Orders");
            builder.HasKey(x => x.IDOrder);
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.UseVocher).IsRequired();
            builder.Property(x => x.CancelOrder).IsRequired();
            builder.Property(x => x.IDInfomationOrder).IsRequired();
            builder.Property(x => x.IDUser).IsRequired();
            builder.Property(x => x.IDPay).IsRequired();
            builder.Property(x => x.IDStatusOrder).IsRequired();

            builder.HasOne<T_InfomationOrder>().WithMany().HasPrincipalKey(x => x.IDInfomationOrder)
                                    .HasForeignKey(x => x.IDInfomationOrder).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Customer>().WithMany().HasPrincipalKey(x => x.IDUser)
                                    .HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_TypePay>().WithMany().HasPrincipalKey(x => x.IDPay)
                                    .HasForeignKey(x => x.IDPay).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_StatusOrder>().WithMany().HasPrincipalKey(x => x.IDStatusOrder)
                                    .HasForeignKey(x => x.IDStatusOrder).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
