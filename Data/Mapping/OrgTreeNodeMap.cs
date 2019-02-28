using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class OrgTreeNodeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.OrgTreeNode>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.OrgTreeNode> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("OrgTreeNode", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ParentId)
                .HasColumnName("ParentId")
                .HasColumnType("int");

            builder.Property(t => t.NodeId)
                .IsRequired()
                .HasColumnName("NodeId")
                .HasColumnType("int");

            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("Code")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.IsActive)
                .IsRequired()
                .HasColumnName("IsActive")
                .HasColumnType("bit");

            builder.Property(t => t.ViewOrder)
                .HasColumnName("ViewOrder")
                .HasColumnType("int");

            builder.Property(t => t.AppObject)
                .HasColumnName("AppObject")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.NodeOrgNode)
                .WithMany(t => t.NodeOrgTreeNodes)
                .HasForeignKey(d => d.NodeId)
                .HasConstraintName("FK_OrgTreeNode_Node");

            builder.HasOne(t => t.ParentOrgTreeNode)
                .WithMany(t => t.ParentOrgTreeNodes)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_OrgTreeNode_ParentNode");

            #endregion
        }

    }
}
