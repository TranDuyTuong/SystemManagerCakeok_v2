using Library.DataTable.TableCakeCustom;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationCakeCustom
{
    public class ConfigurationStatusIdea : IEntityTypeConfiguration<T_StatusIdea>
    {
        public void Configure(EntityTypeBuilder<T_StatusIdea> builder)
        {
            builder.ToTable("T_StatusIdeas");
            builder.HasKey(x => x.IDStatusIdea);
            builder.Property(x => x.IDStatusIdea).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
        }
    }
}
