using Library.DataTable.TableOrder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationOrder
{
    public class ConfigurationTypeAddress : IEntityTypeConfiguration<T_TypeAddress>
    {
        public void Configure(EntityTypeBuilder<T_TypeAddress> builder)
        {
            builder.ToTable("T_TypeAddreses");
            builder.HasKey(x => x.IDTypeAddress);
            builder.Property(x => x.IDTypeAddress).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
        }
    }
}
