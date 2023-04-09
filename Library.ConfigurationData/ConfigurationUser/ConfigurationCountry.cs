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
    public class ConfigurationCountry : IEntityTypeConfiguration<T_Country>
    {
        public void Configure(EntityTypeBuilder<T_Country> builder)
        {
            builder.ToTable("T_Countrys");
            builder.HasKey(x => x.IDCountry);
            builder.Property(x => x.IDCountry).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150).HasColumnType("nvarchar(150)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
