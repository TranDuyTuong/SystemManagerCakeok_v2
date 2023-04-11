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
            builder.Property(x => x.ContentFile).HasColumnType("Nvarchar(MAX)"); ;
            builder.Property(x => x.CreateDate).IsRequired();

            builder.Property(x => x.IDMarriage).IsRequired();
            builder.Property(x => x.IDAccount).IsRequired();
            builder.Property(x => x.IDCustomerOrStaff).IsRequired();
            builder.Property(x => x.IDCity).IsRequired();
            builder.Property(x => x.IDDistrict).IsRequired();
            builder.Property(x => x.IDGender).IsRequired();
            builder.Property(x => x.IDStaffOrChef).IsRequired();

            builder.HasOne(x => x.t_Marriage).WithMany(x => x.t_Staffs).HasForeignKey(x => x.IDMarriage).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_User).WithMany(x => x.t_Staffs).HasForeignKey(x => x.IDAccount).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_CustomerOrStaff).WithMany(x => x.t_Staffs).HasForeignKey(x => x.IDCustomerOrStaff).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_City).WithMany(x => x.t_Staffs).HasForeignKey(x => x.IDCity).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_District).WithMany(x => x.t_Staffs).HasForeignKey(x => x.IDDistrict).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_Gender).WithMany(x => x.t_Staffs).HasForeignKey(x => x.IDGender).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_StaffOrChef).WithMany(x => x.t_Staffs).HasForeignKey(x => x.IDStaffOrChef).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
