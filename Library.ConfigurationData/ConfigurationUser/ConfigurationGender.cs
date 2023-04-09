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
    public class ConfigurationGender : IEntityTypeConfiguration<T_Gender>
    {
        public void Configure(EntityTypeBuilder<T_Gender> builder)
        {
            builder.ToTable("T_Genders");
            builder.HasKey(x => x.IDGender);
            builder.Property(x => x.IDGender).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
