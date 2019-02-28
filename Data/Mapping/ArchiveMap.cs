using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ArchiveMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Archive>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Archive> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Archive", "dbo");

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
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.CategoryId)
                .HasColumnName("CategoryId")
                .HasColumnType("int");

            builder.Property(t => t.SubCategoryId)
                .HasColumnName("SubCategoryId")
                .HasColumnType("int");

            builder.Property(t => t.DateFrom)
                .HasColumnName("DateFrom")
                .HasColumnType("datetime");

            builder.Property(t => t.DateTo)
                .HasColumnName("DateTo")
                .HasColumnType("datetime");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RankId)
                .HasColumnName("RankId")
                .HasColumnType("int");

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
            builder.HasOne(t => t.CategoryArchiveCategory)
                .WithMany(t => t.CategoryArchives)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Archive_ArchiveCategory");

            builder.HasOne(t => t.SubCategoryArchiveSubCategory)
                .WithMany(t => t.SubCategoryArchives)
                .HasForeignKey(d => d.SubCategoryId)
                .HasConstraintName("FK_Archive_ArchiveSubCategory");

            builder.HasOne(t => t.RankDocRank)
                .WithMany(t => t.RankArchives)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("FK_Archive_DocRank");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Archives)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Archive_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Archives)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Archive_User");

            #endregion
        }

    }
}
