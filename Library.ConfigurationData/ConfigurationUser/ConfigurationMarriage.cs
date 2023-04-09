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
    public class ConfigurationMarriage : IEntityTypeConfiguration<T_Marriage>
    {
        public void Configure(EntityTypeBuilder<T_Marriage> builder)
        {
            builder.ToTable("T_Marriages");
            builder.HasKey(x => x.IDMarriage);
            builder.Property(x => x.IDMarriage).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
