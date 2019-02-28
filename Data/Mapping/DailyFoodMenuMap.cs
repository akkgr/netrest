using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class DailyFoodMenuMap
        : IEntityTypeConfiguration<Sca.Data.Entities.DailyFoodMenu>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.DailyFoodMenu> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DailyFoodMenu", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.MenuDate)
                .IsRequired()
                .HasColumnName("MenuDate")
                .HasColumnType("datetime");

            builder.Property(t => t.FoodMenuId)
                .IsRequired()
                .HasColumnName("FoodMenuId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.FoodMenu)
                .WithMany(t => t.DailyFoodMenus)
                .HasForeignKey(d => d.FoodMenuId)
                .HasConstraintName("FK_DailyFoodMenu_FoodMenu");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.DailyFoodMenus)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_DailyFoodMenu_OrgTreeNode");

            #endregion
        }

    }
}
