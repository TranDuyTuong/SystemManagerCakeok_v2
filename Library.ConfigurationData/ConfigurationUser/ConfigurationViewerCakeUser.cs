using Library.DataTable.TableCake;
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
    public class ConfigurationViewerCakeUser : IEntityTypeConfiguration<T_ViewerCakeUser>
    {
        public void Configure(EntityTypeBuilder<T_ViewerCakeUser> builder)
        {
            builder.ToTable("T_ViewerCakeUsers");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.IDUser).IsRequired();
            builder.Property(x => x.IDCake).IsRequired();
            builder.Property(x => x.Amount).IsRequired();

            builder.HasOne<T_Customer>().WithMany().HasPrincipalKey(x => x.IDUser)
                                    .HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Cake>().WithMany().HasPrincipalKey(x => x.IDCake)
                                    .HasForeignKey(x => x.IDCake).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
