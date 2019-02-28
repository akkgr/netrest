using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class WorkGroupMap
        : IEntityTypeConfiguration<Sca.Data.Entities.WorkGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.WorkGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("WorkGroup", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.WorkGroupTypeId)
                .HasColumnName("WorkGroupTypeId")
                .HasColumnType("int");

            builder.Property(t => t.DateStart)
                .HasColumnName("DateStart")
                .HasColumnType("datetime");

            builder.Property(t => t.DateEnd)
                .HasColumnName("DateEnd")
                .HasColumnType("datetime");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.WorkGroups)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_WorkGroup_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.WorkGroups)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_WorkGroup_User");

            builder.HasOne(t => t.WorkGroupType)
                .WithMany(t => t.WorkGroups)
                .HasForeignKey(d => d.WorkGroupTypeId)
                .HasConstraintName("FK_WorkGroup_WorkGroupType");

            #endregion
        }

    }
}
