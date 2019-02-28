using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ProductTransactionMap
        : IEntityTypeConfiguration<Sca.Data.Entities.ProductTransaction>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.ProductTransaction> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProductTransaction", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.TransactionDate)
                .IsRequired()
                .HasColumnName("TransactionDate")
                .HasColumnType("datetime");

            builder.Property(t => t.ProductDate)
                .IsRequired()
                .HasColumnName("ProductDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Product)
                .IsRequired()
                .HasColumnName("Product")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.FoodMenuId)
                .HasColumnName("FoodMenuId")
                .HasColumnType("int");

            builder.Property(t => t.ClientId)
                .HasColumnName("ClientId")
                .HasColumnType("int");

            builder.Property(t => t.IntakeId)
                .HasColumnName("IntakeId")
                .HasColumnType("int");

            builder.Property(t => t.TransactionCause)
                .HasColumnName("TransactionCause")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Quantity)
                .HasColumnName("Quantity")
                .HasColumnType("numeric(18, 0)");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ItemId)
                .HasColumnName("ItemId")
                .HasColumnType("numeric(18, 0)");

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.TransferDestroy)
                .IsRequired()
                .HasColumnName("TransferDestroy")
                .HasColumnType("bit");

            builder.Property(t => t.InternalUse)
                .IsRequired()
                .HasColumnName("InternalUse")
                .HasColumnType("bit");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Client)
                .WithMany(t => t.ProductTransactions)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_ProductTransaction_Client");

            builder.HasOne(t => t.FoodMenuDailyFoodMenu)
                .WithMany(t => t.FoodMenuProductTransactions)
                .HasForeignKey(d => d.FoodMenuId)
                .HasConstraintName("FK_ProductTransaction_DailyFoodMenu");

            builder.HasOne(t => t.Intake)
                .WithMany(t => t.ProductTransactions)
                .HasForeignKey(d => d.IntakeId)
                .HasConstraintName("FK_ProductTransaction_Intake");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.ProductTransactions)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_ProductTransaction_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.ProductTransactions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_ProductTransaction_User");

            #endregion
        }

    }
}
