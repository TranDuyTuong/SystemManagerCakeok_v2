using Library.DataTable.TableRole;
using Library.DataTable.TableStaff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationRole
{
    public class ConfigurationUserRole : IEntityTypeConfiguration<T_UserRole>
    {
        public void Configure(EntityTypeBuilder<T_UserRole> builder)
        {
            builder.ToTable("T_UserRoles");
            builder.HasKey(x => x.IDUserRole);
            builder.Property(x => x.IDUserRole).ValueGeneratedOnAdd();
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.IDRole).IsRequired();
            builder.Property(x => x.IDStaff).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();

            builder.HasOne<T_Role>().WithMany().HasPrincipalKey(x => x.IDRole)
                                    .HasForeignKey(x => x.IDRole).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Staff>().WithMany().HasPrincipalKey(x => x.IDStaff)
                                    .HasForeignKey(x => x.IDStaff).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
