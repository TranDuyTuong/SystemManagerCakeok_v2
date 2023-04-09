using Library.DataTable.TableInformationAuthor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationInfomationAuthor
{
    public class ConfigurationPosition : IEntityTypeConfiguration<T_Position>
    {
        public void Configure(EntityTypeBuilder<T_Position> builder)
        {
            builder.ToTable("T_Positions");
            builder.HasKey(x => x.IDPosition);
            builder.Property(x => x.IDPosition).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
        }
    }
}
