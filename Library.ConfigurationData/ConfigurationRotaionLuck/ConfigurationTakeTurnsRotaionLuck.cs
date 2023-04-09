using Library.DataTable.TableRotationLuck;
using Library.DataTable.TableUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationRotaionLuck
{
    public class ConfigurationTakeTurnsRotaionLuck : IEntityTypeConfiguration<T_TakeTurnsRotaionLuck>
    {
        public void Configure(EntityTypeBuilder<T_TakeTurnsRotaionLuck> builder)
        {
            builder.ToTable("T_TakeTurnsRotaionLucks");
            builder.HasKey(x => x.IDTurns);
            builder.Property(x => x.IDTurns).ValueGeneratedOnAdd();
            builder.Property(x => x.AmountTakeTurn).IsRequired();
            builder.Property(x => x.IDUser).IsRequired();

            builder.HasOne<T_Customer>().WithMany().HasPrincipalKey(x => x.IDUser)
                                    .HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
