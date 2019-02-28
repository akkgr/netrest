using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class DocDocGroupMap
        : IEntityTypeConfiguration<Sca.Data.Entities.DocDocGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.DocDocGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DocDocGroup", "dbo");

            // key
            builder.HasKey(t => new { t.DocId, t.GroupId });

            // properties
            builder.Property(t => t.DocId)
                .IsRequired()
                .HasColumnName("DocId")
                .HasColumnType("int");

            builder.Property(t => t.GroupId)
                .IsRequired()
                .HasColumnName("GroupId")
                .HasColumnType("int");

            builder.Property(t => t.Priority)
                .IsRequired()
                .HasColumnName("Priority")
                .HasColumnType("int")
                .HasDefaultValueSql("((1))");

            // relationships
            builder.HasOne(t => t.GroupDocGroup)
                .WithMany(t => t.GroupDocDocGroups)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_DocDocGroup_DocGroup");

            builder.HasOne(t => t.DocDocument)
                .WithMany(t => t.DocDocDocGroups)
                .HasForeignKey(d => d.DocId)
                .HasConstraintName("FK_DocDocGroup_Document");

            #endregion
        }

    }
}
