using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ParameterMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Parameter>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Parameter> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Parameter", "dbo");

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
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.Value)
                .HasColumnName("Value")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.ValueTypeId)
                .HasColumnName("ValueTypeId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

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
