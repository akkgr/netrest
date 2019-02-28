using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class AutoHistoryMap
        : IEntityTypeConfiguration<Sca.Data.Entities.AutoHistory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.AutoHistory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AutoHistory", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.RowId)
                .IsRequired()
                .HasColumnName("RowId")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.TableName)
                .IsRequired()
                .HasColumnName("TableName")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Changed)
                .HasColumnName("Changed")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Kind)
                .IsRequired()
                .HasColumnName("Kind")
                .HasColumnType("int");

            builder.Property(t => t.Created)
                .IsRequired()
                .HasColumnName("Created")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

    }
}
