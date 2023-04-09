using Library.DataTable.TableUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationUser
{
    public class ConfigurationCustomer : IEntityTypeConfiguration<T_Customer>
    {
        public void Configure(EntityTypeBuilder<T_Customer> builder)
        {
            builder.ToTable("T_Customers");
            builder.HasKey(x => x.IDUser);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Birthday).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(200).HasColumnType("nvarchar(200)");
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(15);
            builder.Property(x => x.ContentFile).IsRequired();
            builder.Property(x => x.MimeFile).IsRequired();
            builder.Property(x => x.TypeFile).IsRequired().HasMaxLength(10);
            builder.Property(x => x.FileName).IsRequired();
            builder.Property(x => x.IDCity).IsRequired();
            builder.Property(x => x.IDDistrict).IsRequired();
            builder.Property(x => x.IDGender).IsRequired();
            builder.Property(x => x.IDCountry).IsRequired();
            builder.Property(x => x.IDCustomerOrStaff).IsRequired();
            builder.Property(x => x.IDAccount).IsRequired();

            builder.HasOne<T_City>().WithMany().HasPrincipalKey(x => x.IDCity)
                                    .HasForeignKey(x => x.IDCity).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_District>().WithMany().HasPrincipalKey(x => x.IDDistrict)
                                    .HasForeignKey(x => x.IDDistrict).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Gender>().WithMany().HasPrincipalKey(x => x.IDGender)
                                    .HasForeignKey(x => x.IDGender).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Country>().WithMany().HasPrincipalKey(x => x.IDCountry)
                                    .HasForeignKey(x => x.IDCountry).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_CustomerOrStaff>().WithMany().HasPrincipalKey(x => x.IDCustomerOrStaff)
                                    .HasForeignKey(x => x.IDCustomerOrStaff).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_User>().WithMany().HasPrincipalKey(x => x.IDAccount)
                                    .HasForeignKey(x => x.IDAccount).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
