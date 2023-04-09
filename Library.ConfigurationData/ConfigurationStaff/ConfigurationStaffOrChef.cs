using Library.DataTable.TableStaff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationStaff
{
    public class ConfigurationStaffOrChef : IEntityTypeConfiguration<T_StaffOrChef>
    {
        public void Configure(EntityTypeBuilder<T_StaffOrChef> builder)
        {
            builder.ToTable("T_StaffOrChefs");
            builder.HasKey(x => x.IDStaffOrChef);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
