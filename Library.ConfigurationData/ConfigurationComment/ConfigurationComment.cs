using Library.DataTable.TableCake;
using Library.DataTable.TableComment;
using Library.DataTable.TableUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationComment
{
    public class ConfigurationComment : IEntityTypeConfiguration<T_Comment>
    {
        public void Configure(EntityTypeBuilder<T_Comment> builder)
        {
            builder.ToTable("T_Comments");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Comment).IsRequired().HasMaxLength(250).HasColumnType("nvarchar(250)");
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.IDUser).IsRequired();
            builder.Property(x => x.IDCake).IsRequired();

            builder.HasOne<T_Customer>().WithMany().HasPrincipalKey(x => x.IDUser)
                                    .HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<T_Cake>().WithMany().HasPrincipalKey(x => x.IDCake)
                                    .HasForeignKey(x => x.IDCake).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
