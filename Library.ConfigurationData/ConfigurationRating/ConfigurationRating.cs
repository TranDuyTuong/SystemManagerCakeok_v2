﻿using Library.DataTable.TableCake;
using Library.DataTable.TableRating;
using Library.DataTable.TableUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConfigurationData.ConfigurationRating
{
    public class ConfigurationRating : IEntityTypeConfiguration<T_Rating>
    {
        public void Configure(EntityTypeBuilder<T_Rating> builder)
        {
            builder.ToTable("T_Ratings");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Rating).IsRequired();
            builder.Property(x => x.CreateDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.IDUser).IsRequired();
            builder.Property(x => x.IDCake).IsRequired();

            builder.HasOne(x => x.t_Customer).WithMany(x => x.t_Ratings).HasForeignKey(x => x.IDUser).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.t_Cake).WithMany(x => x.t_Ratings).HasForeignKey(x => x.IDCake).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
