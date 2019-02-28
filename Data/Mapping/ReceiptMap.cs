using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ReceiptMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Receipt>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Receipt> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Receipt", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Payment)
                .IsRequired()
                .HasColumnName("Payment")
                .HasColumnType("bit");

            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("Code")
                .HasColumnType("int");

            builder.Property(t => t.RankId)
                .IsRequired()
                .HasColumnName("RankId")
                .HasColumnType("int");

            builder.Property(t => t.Publisher)
                .HasColumnName("Publisher")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.TransactionDate)
                .IsRequired()
                .HasColumnName("TransactionDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Trader)
                .HasColumnName("Trader")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.TaxRecocrd)
                .HasColumnName("TaxRecocrd")
                .HasColumnType("nvarchar(9)")
                .HasMaxLength(9);

            builder.Property(t => t.Cash)
                .IsRequired()
                .HasColumnName("Cash")
                .HasColumnType("decimal(18, 2)");

            builder.Property(t => t.Other)
                .IsRequired()
                .HasColumnName("Other")
                .HasColumnType("decimal(18, 2)");

            builder.Property(t => t.BankTransfer)
                .IsRequired()
                .HasColumnName("BankTransfer")
                .HasColumnType("bit");

            builder.Property(t => t.BankCheck)
                .IsRequired()
                .HasColumnName("BankCheck")
                .HasColumnType("bit");

            builder.Property(t => t.BankRemarks)
                .HasColumnName("BankRemarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.RankDocRank)
                .WithMany(t => t.RankReceipts)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("FK_Receipt_DocRank");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Receipts)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Receipt_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Receipts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Receipt_User");

            #endregion
        }

    }
}
