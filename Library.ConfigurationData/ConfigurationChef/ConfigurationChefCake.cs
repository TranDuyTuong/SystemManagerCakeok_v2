using Library.DataTable.TableCake;
using Library.DataTable.TableChef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationChef
{
    public class ConfigurationChefCake : IEntityTypeConfiguration<T_ChefCake>
    {
        public void Configure(EntityTypeBuilder<T_ChefCake> builder)
        {
            builder.ToTable("T_ChefCakes");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.IDChef).IsRequired();
            builder.Property(x => x.IDCake).IsRequired();

            builder.HasOne<T_Chef>().WithMany().HasPrincipalKey(x => x.IDChef)
                                    .HasForeignKey(x => x.IDChef).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Cake>().WithMany().HasPrincipalKey(x => x.IDCake)
                                    .HasForeignKey(x => x.IDCake).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
