using Library.DataTable.TableVocher;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationVocher
{
    public class ConfigurationVocher : IEntityTypeConfiguration<T_Vocher>
    {
        public void Configure(EntityTypeBuilder<T_Vocher> builder)
        {
            builder.ToTable("T_Vochers");
            builder.HasKey(x => x.IDVocher);
            builder.Property(x => x.NameVocher).IsRequired().HasMaxLength(200).HasColumnType("nvarchar(200)");
            builder.Property(x => x.Code).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.PercenReduction).IsRequired();
        }
    }
}
