using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class BoardMemberMap
        : IEntityTypeConfiguration<Sca.Data.Entities.BoardMember>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.BoardMember> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("BoardMember", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.LastName)
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Adt)
                .HasColumnName("ADT")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Position)
                .IsRequired()
                .HasColumnName("Position")
                .HasColumnType("int");

            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Decision)
                .HasColumnName("Decision")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Signature)
                .HasColumnName("Signature")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.PositionBoardMemberType)
                .WithMany(t => t.PositionBoardMembers)
                .HasForeignKey(d => d.Position)
                .HasConstraintName("FK_BoardMember_BoardMemberType");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.BoardMembers)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_BoardMember_OrgTreeNode");

            #endregion
        }

    }
}
