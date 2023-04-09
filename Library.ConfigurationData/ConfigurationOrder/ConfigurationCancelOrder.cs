using Library.DataTable.TableOrder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationOrder
{
    public class ConfigurationCancelOrder : IEntityTypeConfiguration<T_CancelOrder>
    {
        public void Configure(EntityTypeBuilder<T_CancelOrder> builder)
        {
            builder.ToTable("T_CancelOrders");
            builder.HasKey(x => x.IDCancel);
            builder.Property(x => x.Note).IsRequired().HasMaxLength(200).HasColumnType("nvarchar(200)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.IDOrder).IsRequired();

            builder.HasOne<T_Order>().WithMany().HasPrincipalKey(x => x.IDOrder)
                                    .HasForeignKey(x => x.IDOrder).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
