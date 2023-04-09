using Library.DataTable.TableRole;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationRole
{
    public class ConfigurationRole : IEntityTypeConfiguration<T_Role>
    {
        public void Configure(EntityTypeBuilder<T_Role> builder)
        {
            builder.ToTable("T_Roles");
            builder.HasKey(x => x.IDRole);
            builder.Property(x => x.NameRole).HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Symbol).HasMaxLength(20);
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Discripttion).HasMaxLength(200).HasColumnType("nvarchar(200)");
        }
    }
}
