using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ItemTransactionMap
        : IEntityTypeConfiguration<Sca.Data.Entities.ItemTransaction>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.ItemTransaction> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ItemTransaction", "dbo");

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

            builder.Property(t => t.ItemId)
                .IsRequired()
                .HasColumnName("ItemId")
                .HasColumnType("int");

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

            builder.Property(t => t.TransactionCause)
                .HasColumnName("TransactionCause")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.ClientId)
                .HasColumnName("ClientId")
                .HasColumnType("int");

            builder.Property(t => t.IntakeId)
                .HasColumnName("IntakeId")
                .HasColumnType("int");

            builder.Property(t => t.Xpiration)
                .HasColumnName("Εxpiration")
                .HasColumnType("date");

            builder.Property(t => t.OriginId)
                .HasColumnName("OriginId")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.TransactionType)
                .IsRequired()
                .HasColumnName("TransactionType")
                .HasColumnType("numeric(2, 0)");

            builder.Property(t => t.BarCode)
                .IsRequired()
                .HasColumnName("BarCode")
                .HasColumnType("nvarchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.Processed)
                .IsRequired()
                .HasColumnName("Processed")
                .HasColumnType("bit");

            builder.Property(t => t.Doctor)
                .HasColumnName("Doctor")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.Prescription)
                .HasColumnName("Prescription")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Invoice)
                .HasColumnName("Invoice")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.RunningTotal)
                .HasColumnName("RunningTotal")
                .HasColumnType("numeric(18, 2)");

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
                .WithMany(t => t.ItemTransactions)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_ItemTransaction_Client");

            builder.HasOne(t => t.Intake)
                .WithMany(t => t.ItemTransactions)
                .HasForeignKey(d => d.IntakeId)
                .HasConstraintName("FK_ItemTransaction_Intake");

            builder.HasOne(t => t.Item)
                .WithMany(t => t.ItemTransactions)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_ItemTransaction_Item");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.ItemTransactions)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_ItemTransaction_OrgTreeNode");

            builder.HasOne(t => t.Origin)
                .WithMany(t => t.ItemTransactions)
                .HasForeignKey(d => d.OriginId)
                .HasConstraintName("FK_ItemTransaction_Origin");

            builder.HasOne(t => t.User)
                .WithMany(t => t.ItemTransactions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_ItemTransaction_User");

            #endregion
        }

    }
}
