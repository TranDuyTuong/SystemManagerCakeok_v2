using Library.DataTable.TableCake;
using Library.DataTable.TableOrder;
using Library.DataTable.TableStaff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationOrder
{
    public class ConfigurationOrderDetail : IEntityTypeConfiguration<T_OrderDetail>
    {
        public void Configure(EntityTypeBuilder<T_OrderDetail> builder)
        {
            builder.ToTable("T_OrderDetails");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Quatity).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.TotalPrice).IsRequired();
            builder.Property(x => x.IDStaff).IsRequired();
            builder.Property(x => x.IDOrder).IsRequired();
            builder.Property(x => x.IDCake).IsRequired();
            builder.Property(x => x.IDGift).IsRequired();
            builder.Property(x => x.IDSmell).IsRequired();

            builder.HasOne<T_Staff>().WithMany().HasPrincipalKey(x => x.IDStaff)
                                    .HasForeignKey(x => x.IDStaff).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Order>().WithMany().HasPrincipalKey(x => x.IDOrder)
                                    .HasForeignKey(x => x.IDOrder).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Cake>().WithMany().HasPrincipalKey(x => x.IDCake)
                                    .HasForeignKey(x => x.IDCake).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Gift>().WithMany().HasPrincipalKey(x => x.IDGift)
                                    .HasForeignKey(x => x.IDGift).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_SmellCake>().WithMany().HasPrincipalKey(x => x.IDSmell)
                                    .HasForeignKey(x => x.IDSmell).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
