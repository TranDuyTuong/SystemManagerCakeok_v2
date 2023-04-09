using Library.DataTable.TableStaff;
using Library.DataTable.TableUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationStaff
{
    public class ConfigurationStaff : IEntityTypeConfiguration<T_Staff>
    {
        public void Configure(EntityTypeBuilder<T_Staff> builder)
        {
            builder.ToTable("T_Staffs");
            builder.HasKey(x => x.IDStaff);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(100).HasColumnType("Nvarchar(100)");
            builder.Property(x => x.Birthday).IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(200).HasColumnType("Nvarchar(200)");
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(15);
            builder.Property(x => x.IDCode).IsRequired().HasMaxLength(100);
            builder.Property(x => x.ContentFile).IsRequired().HasColumnType("Nvarchar(MAX)"); ;
            builder.Property(x => x.FileName).IsRequired();
            builder.Property(x => x.TypeImage).IsRequired().HasMaxLength(20);
            builder.Property(x => x.MimeType).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();

            builder.Property(x => x.IDMarriage).IsRequired();
            builder.Property(x => x.IDAccount).IsRequired();
            builder.Property(x => x.IDCustomerOrStaff).IsRequired();
            builder.Property(x => x.IDCity).IsRequired();
            builder.Property(x => x.IDDistrict).IsRequired();
            builder.Property(x => x.IDGender).IsRequired();
            builder.Property(x => x.IDStaffOrChef).IsRequired();

            builder.HasOne<T_Marriage>().WithMany().HasPrincipalKey(x => x.IDMarriage)
                                    .HasForeignKey(x => x.IDMarriage).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_User>().WithMany().HasPrincipalKey(x => x.IDAccount)
                                    .HasForeignKey(x => x.IDAccount).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_CustomerOrStaff>().WithMany().HasPrincipalKey(x => x.IDCustomerOrStaff)
                                    .HasForeignKey(x => x.IDCustomerOrStaff).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_City>().WithMany().HasPrincipalKey(x => x.IDCity)
                                    .HasForeignKey(x => x.IDCity).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_District>().WithMany().HasPrincipalKey(x => x.IDDistrict)
                                    .HasForeignKey(x => x.IDDistrict).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Gender>().WithMany().HasPrincipalKey(x => x.IDGender)
                                    .HasForeignKey(x => x.IDGender).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_StaffOrChef>().WithMany().HasPrincipalKey(x => x.IDStaffOrChef)
                                    .HasForeignKey(x => x.IDStaffOrChef).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
