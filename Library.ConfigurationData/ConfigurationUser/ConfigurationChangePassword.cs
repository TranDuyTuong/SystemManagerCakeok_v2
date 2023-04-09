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
    public class ConfigurationChangePassword : IEntityTypeConfiguration<T_ChangePassword>
    {
        public void Configure(EntityTypeBuilder<T_ChangePassword> builder)
        {
            builder.ToTable("T_ChangePasswords");
            builder.HasKey(x => x.IDChange);
            builder.Property(x => x.EmailRequest).IsRequired().HasMaxLength(100);
            builder.Property(x => x.DateRequest).HasColumnType("datetime").IsRequired();
        }
    }
}
