using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class OrgNodeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.OrgNode>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.OrgNode> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("OrgNode", "dbo");

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

            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("Code")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.NodeTypeId)
                .IsRequired()
                .HasColumnName("NodeTypeId")
                .HasColumnType("int");

            builder.Property(t => t.IsActive)
                .IsRequired()
                .HasColumnName("IsActive")
                .HasColumnType("bit");

            builder.Property(t => t.ViewOrder)
                .HasColumnName("ViewOrder")
                .HasColumnType("int");

            builder.Property(t => t.AppObject)
                .HasColumnName("AppObject")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.NodeTypeOrgNodeType)
                .WithMany(t => t.NodeTypeOrgNodes)
                .HasForeignKey(d => d.NodeTypeId)
                .HasConstraintName("FK_OrgNode_OrgNodeType");

            #endregion
        }

    }
}
