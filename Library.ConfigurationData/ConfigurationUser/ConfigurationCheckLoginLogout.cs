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
    public class ConfigurationCheckLoginLogout : IEntityTypeConfiguration<T_CheckLoginLogout>
    {
        public void Configure(EntityTypeBuilder<T_CheckLoginLogout> builder)
        {
            builder.ToTable("T_CheckLoginLogouts");
            builder.HasKey(x => x.WorkingStart);
            builder.Property(x => x.IDStaff).IsRequired(true);
            builder.Property(x => x.TimeStart).IsRequired(true);
            builder.Property(x => x.DateStart).IsRequired(true);
        }
    }
}
