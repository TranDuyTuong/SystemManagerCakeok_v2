using Library.DataTable.TableChef;
using Library.DataTable.TableStaff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationChef
{
    public class ConfigurationChef : IEntityTypeConfiguration<T_Chef>
    {
        public void Configure(EntityTypeBuilder<T_Chef> builder)
        {
            builder.ToTable("T_Chefs");
            builder.HasKey(x => x.IDChef);
            builder.Property(x => x.NoChef).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(250)");
            builder.Property(x => x.Experience).IsRequired();
            builder.Property(x => x.IDStaff).IsRequired();

            builder.HasOne<T_Staff>().WithMany().HasPrincipalKey(x => x.IDStaff)
                                    .HasForeignKey(x => x.IDStaff).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
