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
    public class ConfigurationUser : IEntityTypeConfiguration<T_User>
    {
        public void Configure(EntityTypeBuilder<T_User> builder)
        {
            builder.ToTable("T_Users");
            builder.HasKey(x => x.IDAccount);
            builder.Property(x => x.PassWord).IsRequired().HasColumnType("varchar(MAX)");
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.IDCustomerOrStaff).IsRequired();
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.t_CustomerOrStaff).WithMany(x => x.t_Users).HasForeignKey(x => x.IDCustomerOrStaff).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
