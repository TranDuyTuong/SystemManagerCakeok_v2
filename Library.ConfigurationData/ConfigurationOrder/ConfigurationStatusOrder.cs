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
    public class ConfigurationStatusOrder : IEntityTypeConfiguration<T_StatusOrder>
    {
        public void Configure(EntityTypeBuilder<T_StatusOrder> builder)
        {
            builder.ToTable("T_StatusOrders");
            builder.HasKey(x => x.IDStatusOrder);
            builder.Property(x => x.IDStatusOrder).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.PesentProgess).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
