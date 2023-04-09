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
    public class ConfigurationDistrict : IEntityTypeConfiguration<T_District>
    {
        public void Configure(EntityTypeBuilder<T_District> builder)
        {
            builder.ToTable("T_Districts");
            builder.HasKey(x => x.IDDistrict);
            builder.Property(x => x.IDDistrict).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200).HasColumnType("nvarchar(200)");
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.IDCity).IsRequired();

            builder.HasOne<T_City>().WithMany().HasPrincipalKey(x => x.IDCity)
                                    .HasForeignKey(x => x.IDCity).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
