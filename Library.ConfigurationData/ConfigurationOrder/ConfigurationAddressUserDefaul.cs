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
    public class ConfigurationAddressUserDefaul : IEntityTypeConfiguration<T_AddressUserDefaul>
    {
        public void Configure(EntityTypeBuilder<T_AddressUserDefaul> builder)
        {
            builder.ToTable("T_AddressUserDefauls");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Address).IsRequired().HasColumnType("nvarchar(250)");
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.IDTypeAddress).IsRequired();
            builder.Property(x => x.IDCity).IsRequired();
            builder.Property(x => x.IDDistrict).IsRequired();
            builder.Property(x => x.IDUser).IsRequired();

            builder.HasOne<T_TypeAddress>().WithMany().HasPrincipalKey(x => x.IDTypeAddress)
                                    .HasForeignKey(x => x.IDTypeAddress).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_City>().WithMany().HasPrincipalKey(x => x.IDCity)
                                    .HasForeignKey(x => x.IDCity).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_District>().WithMany().HasPrincipalKey(x => x.IDDistrict)
                                    .HasForeignKey(x => x.IDDistrict).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Customer>().WithMany().HasPrincipalKey(x => x.IDUser)
                                    .HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
