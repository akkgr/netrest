using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ItemMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Item>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Item> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Item", "dbo");

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
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.PackagingId)
                .IsRequired()
                .HasColumnName("PackagingId")
                .HasColumnType("int");

            builder.Property(t => t.CategoryId)
                .IsRequired()
                .HasColumnName("CategoryId")
                .HasColumnType("int");

            builder.Property(t => t.UnitId)
                .IsRequired()
                .HasColumnName("UnitId")
                .HasColumnType("int");

            builder.Property(t => t.Quantity)
                .IsRequired()
                .HasColumnName("Quantity")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Price)
                .IsRequired()
                .HasColumnName("Price")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.BarCode)
                .IsRequired()
                .HasColumnName("BarCode")
                .HasColumnType("nvarchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.Company)
                .HasColumnName("Company")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ActiveSubstance)
                .HasColumnName("ActiveSubstance")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Category)
                .WithMany(t => t.Items)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Item_Category");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Items)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Item_OrgTreeNode");

            builder.HasOne(t => t.Packaging)
                .WithMany(t => t.Items)
                .HasForeignKey(d => d.PackagingId)
                .HasConstraintName("FK_Item_Packaging");

            builder.HasOne(t => t.Unit)
                .WithMany(t => t.Items)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_Item_Unit");

            #endregion
        }

    }
}
