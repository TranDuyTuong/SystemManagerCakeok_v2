using Library.DataTable.TableCake;
using Library.DataTable.TableCakeCustom;
using Library.DataTable.TableUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationCakeCustom
{
    public class ConfigurationCakeCustomIdea : IEntityTypeConfiguration<T_CakeCustomIdea>
    {
        public void Configure(EntityTypeBuilder<T_CakeCustomIdea> builder)
        {
            builder.ToTable("T_CakeCustomIdeas");
            builder.HasKey(x => x.IDIdea);
            builder.Property(x => x.IDIdea).ValueGeneratedOnAdd();
            builder.Property(x => x.Content).IsRequired().HasColumnType("nvarchar(300)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.IDTypeCake).IsRequired();
            builder.Property(x => x.IDUser).IsRequired();
            builder.Property(x => x.IDSize).IsRequired();
            builder.Property(x => x.IDStatusIdea).IsRequired();

            builder.HasOne<T_TypeCake>().WithMany().HasPrincipalKey(x => x.IDTypeCake)
                                    .HasForeignKey(x => x.IDTypeCake).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Customer>().WithMany().HasPrincipalKey(x => x.IDUser)
                                    .HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_SizeCake>().WithMany().HasPrincipalKey(x => x.IDSize)
                                    .HasForeignKey(x => x.IDSize).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_StatusIdea>().WithMany().HasPrincipalKey(x => x.IDStatusIdea)
                                    .HasForeignKey(x => x.IDStatusIdea).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
