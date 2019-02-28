using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class FoodMenuMap
        : IEntityTypeConfiguration<Sca.Data.Entities.FoodMenu>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.FoodMenu> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("FoodMenu", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            // relationships
            #endregion
        }

    }
}
