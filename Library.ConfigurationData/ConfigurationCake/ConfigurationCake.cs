using Library.DataTable.TableCake;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationCake
{
    public class ConfigurationCake : IEntityTypeConfiguration<T_Cake>
    {
        public void Configure(EntityTypeBuilder<T_Cake> builder)
        {
            builder.ToTable("T_Cakes");
            builder.HasKey(x => x.IDCake);
            builder.Property(x => x.NoCake).IsRequired().HasMaxLength(250);
            builder.Property(x => x.NameCake).IsRequired().HasMaxLength(250).HasColumnType("nvarchar(250)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.View).IsRequired();
            builder.Property(x => x.Buy).IsRequired();
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.Width).IsRequired();
            builder.Property(x => x.Height).IsRequired();
            builder.Property(x => x.IDKindCake).IsRequired();
            builder.Property(x => x.IDStatus).IsRequired();
            builder.Property(x => x.IDNewCake).IsRequired();
            builder.Property(x => x.IDPrice).IsRequired();
            builder.Property(x => x.IDTypeCake).IsRequired();
            builder.Property(x => x.IDDiscount).IsRequired();
            builder.Property(x => x.IDElement).IsRequired();
            builder.Property(x => x.IDSmell).IsRequired();

            builder.HasOne<T_KindCake>().WithMany().HasPrincipalKey(x => x.IDKindCake)
                                        .HasForeignKey(x => x.IDKindCake).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_StatusCake>().WithMany().HasPrincipalKey(x => x.IDStatus)
                                        .HasForeignKey(x => x.IDStatus).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_NewCake>().WithMany().HasPrincipalKey(x => x.IDNewCake)
                                        .HasForeignKey(x => x.IDNewCake).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_CakePrice>().WithMany().HasPrincipalKey(x => x.IDPrice)
                                        .HasForeignKey(x => x.IDPrice).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_TypeCake>().WithMany().HasPrincipalKey(x => x.IDTypeCake)
                                        .HasForeignKey(x => x.IDTypeCake).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_DiscountCake>().WithMany().HasPrincipalKey(x => x.IDDiscount)
                                        .HasForeignKey(x => x.IDDiscount).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_CakeElement>().WithMany().HasPrincipalKey(x => x.IDElement)
                                        .HasForeignKey(x => x.IDElement).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_SmellCake>().WithMany().HasPrincipalKey(x => x.IDSmell)
                                        .HasForeignKey(x => x.IDSmell).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
