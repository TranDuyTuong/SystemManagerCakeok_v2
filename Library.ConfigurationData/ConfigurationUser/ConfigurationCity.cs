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
    public class ConfigurationCity : IEntityTypeConfiguration<T_City>
    {
        public void Configure(EntityTypeBuilder<T_City> builder)
        {
            builder.ToTable("T_Citys");
            builder.HasKey(x => x.IDCity);
            builder.Property(x => x.IDCity).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
