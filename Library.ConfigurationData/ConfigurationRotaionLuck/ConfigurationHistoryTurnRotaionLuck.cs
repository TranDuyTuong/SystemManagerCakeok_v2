using Library.DataTable.TableRotationLuck;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationRotaionLuck
{
    public class ConfigurationHistoryTurnRotaionLuck : IEntityTypeConfiguration<T_HistoryTurnRotaionLuck>
    {
        public void Configure(EntityTypeBuilder<T_HistoryTurnRotaionLuck> builder)
        {
            builder.ToTable("T_HistoryTurnRotaionLucks");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Note).IsRequired().HasMaxLength(200).HasColumnType("nvarchar(200)");
            builder.Property(x => x.IDUser).IsRequired();
        }
    }
}
