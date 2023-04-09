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
    public class ConfigurationTokenLogin : IEntityTypeConfiguration<T_TokenLogin>
    {
        public void Configure(EntityTypeBuilder<T_TokenLogin> builder)
        {
            builder.ToTable("T_TokenLogins");
            builder.HasKey(x => x.IDToken);
            builder.Property(x => x.IDToken).ValueGeneratedOnAdd();
            builder.Property(x => x.CreateDate).IsRequired(true);
            builder.Property(x => x.TokenString).IsRequired(true);
            builder.Property(x => x.EmailLogin).IsRequired(true);
        }
    }
}
