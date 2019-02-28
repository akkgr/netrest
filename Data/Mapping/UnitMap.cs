using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class UnitMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Unit>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Unit> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Unit", "dbo");

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
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            #endregion
        }

    }
}