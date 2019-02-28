using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class PublicationOrgNodeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.PublicationOrgNode>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.PublicationOrgNode> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PublicationOrgNode", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.PublicationId)
                .IsRequired()
                .HasColumnName("PublicationId")
                .HasColumnType("int");

            builder.Property(t => t.OrgNodeId)
                .IsRequired()
                .HasColumnName("OrgNodeId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.OrgNode)
                .WithMany(t => t.PublicationOrgNodes)
                .HasForeignKey(d => d.OrgNodeId)
                .HasConstraintName("FK_PublicationOrgNode_OrgNode");

            builder.HasOne(t => t.Publication)
                .WithMany(t => t.PublicationOrgNodes)
                .HasForeignKey(d => d.PublicationId)
                .HasConstraintName("FK_PublicationOrgNode_Publication");

            #endregion
        }

    }
}
