using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ItemGroupMap
        : IEntityTypeConfiguration<Sca.Data.Entities.ItemGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.ItemGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ItemGroup", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ItemId)
                .IsRequired()
                .HasColumnName("ItemId")
                .HasColumnType("int");

            builder.Property(t => t.Quantity)
                .IsRequired()
                .HasColumnName("Quantity")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.GroupId)
                .HasColumnName("GroupId")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.GroupName)
                .HasColumnName("GroupName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Item)
                .WithMany(t => t.ItemGroups)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_ItemGroup_Item");

            #endregion
        }

    }
}
