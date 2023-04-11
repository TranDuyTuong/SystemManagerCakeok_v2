using Library.DataTable.TableCakeCustom;
using Library.DataTable.TableStaff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationCakeCustom
{
    public class ConfigurationBillCakeCustom : IEntityTypeConfiguration<T_BillCakeCustom>
    {
        public void Configure(EntityTypeBuilder<T_BillCakeCustom> builder)
        {
            builder.ToTable("T_BillCakeCustoms");
            builder.HasKey(x => x.IDBill);
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.AmountCake).IsRequired();
            builder.Property(x => x.TotalPrice).IsRequired();
            builder.Property(x => x.IDPriceCustom).IsRequired();
            builder.Property(x => x.IDPay).IsRequired();
            builder.Property(x => x.IDTypePay).IsRequired();
            builder.Property(x => x.IDCustom).IsRequired();
            builder.Property(x => x.IDStaff).IsRequired();

            builder.HasOne(x => x.t_CustomCakePrice).WithMany(x => x.t_BillCakeCustoms).HasForeignKey(x => x.IDPriceCustom).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_PayCustomCake).WithMany(x => x.t_BillCakeCustom).HasForeignKey(x => x.IDPay).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_TypePayCustomCake).WithMany(x => x.t_BillCakeCustoms).HasForeignKey(x => x.IDTypePay).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_CustomCake).WithMany(x => x.t_BillCakeCustom).HasForeignKey(x => x.IDCustom).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_Staff).WithMany(x => x.t_BillCakeCustoms).HasForeignKey(x => x.IDStaff).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
