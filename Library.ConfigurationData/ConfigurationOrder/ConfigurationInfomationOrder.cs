using Library.DataTable.TableBranch;
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
    public class ConfigurationInfomationOrder : IEntityTypeConfiguration<T_InfomationOrder>
    {
        public void Configure(EntityTypeBuilder<T_InfomationOrder> builder)
        {
            builder.ToTable("T_InfomationOrders");
            builder.HasKey(x => x.IDInfomationOrder);
            builder.Property(x => x.NameCustomer).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.EmailCustomer).IsRequired().HasMaxLength(100);
            builder.Property(x => x.PhoneCustomer).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(250)");
            builder.Property(x => x.ExpecteDate).IsRequired();
            builder.Property(x => x.NoteCustomer).IsRequired().HasColumnType("nvarchar(300)");
            builder.Property(x => x.IDCity).IsRequired();
            builder.Property(x => x.IDDistrict).IsRequired();

            builder.HasOne<T_City>().WithMany().HasPrincipalKey(x => x.IDCity)
                                    .HasForeignKey(x => x.IDCity).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_District>().WithMany().HasPrincipalKey(x => x.IDDistrict)
                                    .HasForeignKey(x => x.IDDistrict).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Branch>().WithMany().HasPrincipalKey(x => x.IDBrach)
                                    .HasForeignKey(x => x.IDBrach).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
