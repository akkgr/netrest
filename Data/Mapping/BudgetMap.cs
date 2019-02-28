using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class BudgetMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Budget>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Budget> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Budget", "dbo");

            // key
            builder.HasKey(t => new { t.OrgTreeNodeId, t.FinanceYear, t.ActivityCodeId });

            // properties
            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.FinanceYear)
                .IsRequired()
                .HasColumnName("FinanceYear")
                .HasColumnType("int");

            builder.Property(t => t.ActivityCodeId)
                .IsRequired()
                .HasColumnName("ActivityCodeId")
                .HasColumnType("int");

            builder.Property(t => t.ActivityCode)
                .HasColumnName("ActivityCode")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.BudgetAmount)
                .IsRequired()
                .HasColumnName("BudgetAmount")
                .HasColumnType("decimal(18, 2)");

            builder.Property(t => t.AccountAmount)
                .IsRequired()
                .HasColumnName("AccountAmount")
                .HasColumnType("decimal(18, 2)");

            builder.Property(t => t.UsedRate)
                .IsRequired()
                .HasColumnName("UsedRate")
                .HasColumnType("decimal(18, 2)");

            builder.Property(t => t.RefAmount)
                .IsRequired()
                .HasColumnName("RefAmount")
                .HasColumnType("decimal(18, 2)");

            // relationships
            builder.HasOne(t => t.ActivityCode1)
                .WithMany(t => t.Budgets)
                .HasForeignKey(d => d.ActivityCodeId)
                .HasConstraintName("FK_Budget_ActivityCode");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Budgets)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Budget_OrgTreeNode");

            #endregion
        }

    }
}
