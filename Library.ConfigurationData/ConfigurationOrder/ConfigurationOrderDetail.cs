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

            builder.HasOne(x => x.t_Staff).WithMany(x => x.t_OrderDetails).HasForeignKey(x => x.IDStaff).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_Order).WithMany(x => x.t_OrderDetails).HasForeignKey(x => x.IDOrder).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_Cake).WithMany(x => x.t_OrderDetails).HasForeignKey(x => x.IDCake).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_Gift).WithMany(x => x.t_OrderDetails).HasForeignKey(x => x.IDGift).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_SmellCake).WithMany(x => x.t_OrderDetails).HasForeignKey(x => x.IDSmell).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
