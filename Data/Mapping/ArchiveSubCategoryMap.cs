using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ArchiveSubCategoryMap
        : IEntityTypeConfiguration<Sca.Data.Entities.ArchiveSubCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.ArchiveSubCategory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ArchiveSubCategory", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CategoryId)
                .IsRequired()
                .HasColumnName("CategoryId")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.CategoryArchiveCategory)
                .WithMany(t => t.CategoryArchiveSubCategories)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_ArchiveSubCategory_ArchiveCategory");

            #endregion
        }

    }
}
