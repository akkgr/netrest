using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class NodeToNodeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.NodeToNode>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.NodeToNode> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("NodeToNode", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ParentNode)
                .IsRequired()
                .HasColumnName("ParentNode")
                .HasColumnType("int");

            builder.Property(t => t.ChildNode)
                .IsRequired()
                .HasColumnName("ChildNode")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.ParentNodeOrgTreeNode)
                .WithMany(t => t.ParentNodeNodeToNodes)
                .HasForeignKey(d => d.ParentNode)
                .HasConstraintName("FK_NodeToNode_OrgTreeNode");

            builder.HasOne(t => t.ChildNodeOrgTreeNode)
                .WithMany(t => t.ChildNodeNodeToNodes)
                .HasForeignKey(d => d.ChildNode)
                .HasConstraintName("FK_NodeToNode_OrgTreeNode1");

            builder.HasOne(t => t.User)
                .WithMany(t => t.NodeToNodes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_NodeToNode_User");

            #endregion
        }

    }
}
