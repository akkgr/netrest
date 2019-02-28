using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class OrgNodeTypeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.OrgNodeType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.OrgNodeType> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("OrgNodeType", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.TreeLevel)
                .IsRequired()
                .HasColumnName("TreeLevel")
                .HasColumnType("int");

            builder.Property(t => t.UserAvailable)
                .IsRequired()
                .HasColumnName("UserAvailable")
                .HasColumnType("bit");

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
