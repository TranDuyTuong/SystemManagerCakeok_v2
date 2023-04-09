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
    public class ConfigurationCustomerOrStaff : IEntityTypeConfiguration<T_CustomerOrStaff>
    {
        public void Configure(EntityTypeBuilder<T_CustomerOrStaff> builder)
        {
            builder.ToTable("T_CustomerOrStaffs");
            builder.HasKey(x => x.IDCustomerOrStaff);
            builder.Property(x => x.IDCustomerOrStaff).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200).HasColumnType("nvarchar(200)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
        }
    }
}
