using Library.DataTable.TableBranch;
using Library.DataTable.TableUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationBranch
{
    public class ConfigurationBranch : IEntityTypeConfiguration<T_Branch>
    {
        public void Configure(EntityTypeBuilder<T_Branch> builder)
        {
            builder.ToTable("T_Branchs");
            builder.HasKey(x => x.IDBrach);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(250).HasColumnType("nvarchar(250)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(250).HasColumnType("nvarchar(250)");
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.TimeWorking).IsRequired().HasMaxLength(250).HasColumnType("nvarchar(250)");
            builder.Property(x => x.IDRegion).IsRequired();
            builder.Property(x => x.IDCity).IsRequired();
            builder.Property(x => x.IDDistrict).IsRequired();

            builder.HasOne(x => x.t_Regions).WithMany(x => x.t_Branch).HasForeignKey(x => x.IDRegion).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_City).WithMany(x => x.t_Branches).HasForeignKey(x => x.IDCity).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_District).WithMany(x => x.t_Branches).HasForeignKey(x => x.IDDistrict).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
