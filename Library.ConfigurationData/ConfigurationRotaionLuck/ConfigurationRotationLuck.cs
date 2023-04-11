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
    public class ConfigurationRotationLuck : IEntityTypeConfiguration<T_RotationLuck>
    {
        public void Configure(EntityTypeBuilder<T_RotationLuck> builder)
        {
            builder.ToTable("T_RotationLucks");
            builder.HasKey(x => x.IDRotation);
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.PercentPage).IsRequired();
            builder.Property(x => x.IDLuck).IsRequired();

            builder.HasOne(x => x.t_GiftLuck).WithMany(x => x.t_RotationLucks).HasForeignKey(x => x.IDLuck).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
