using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class AssetTransactionMap
        : IEntityTypeConfiguration<Sca.Data.Entities.AssetTransaction>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.AssetTransaction> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AssetTransaction", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.AssetId)
                .IsRequired()
                .HasColumnName("AssetId")
                .HasColumnType("int");

            builder.Property(t => t.InvoiceTypeId)
                .HasColumnName("InvoiceTypeId")
                .HasColumnType("int");

            builder.Property(t => t.InvoiceNo)
                .HasColumnName("InvoiceNo")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.InvoiceDate)
                .HasColumnName("InvoiceDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.OrgFrom)
                .HasColumnName("OrgFrom")
                .HasColumnType("int");

            builder.Property(t => t.OrgTo)
                .HasColumnName("OrgTo")
                .HasColumnType("int");

            builder.Property(t => t.Pending)
                .HasColumnName("Pending")
                .HasColumnType("bit");

            builder.Property(t => t.Disposed)
                .HasColumnName("Disposed")
                .HasColumnType("bit");

            builder.Property(t => t.EmployeeId)
                .HasColumnName("EmployeeId")
                .HasColumnType("int");

            builder.Property(t => t.Employee)
                .HasColumnName("Employee")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.ChargeDate)
                .HasColumnName("ChargeDate")
                .HasColumnType("datetime");

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
            builder.HasOne(t => t.Asset)
                .WithMany(t => t.AssetTransactions)
                .HasForeignKey(d => d.AssetId)
                .HasConstraintName("FK_AssetTransaction_Asset");

            builder.HasOne(t => t.Employee1)
                .WithMany(t => t.AssetTransactions)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_AssetTransaction_Employee");

            builder.HasOne(t => t.InvoiceType)
                .WithMany(t => t.AssetTransactions)
                .HasForeignKey(d => d.InvoiceTypeId)
                .HasConstraintName("FK_AssetTransaction_InvoiceType");

            builder.HasOne(t => t.OrgFromOrgTreeNode)
                .WithMany(t => t.OrgFromAssetTransactions)
                .HasForeignKey(d => d.OrgFrom)
                .HasConstraintName("FK_AssetTransaction_OrgTreeNode");

            builder.HasOne(t => t.OrgToOrgTreeNode)
                .WithMany(t => t.OrgToAssetTransactions)
                .HasForeignKey(d => d.OrgTo)
                .HasConstraintName("FK_AssetTransaction_OrgTreeNode1");

            builder.HasOne(t => t.User)
                .WithMany(t => t.AssetTransactions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AssetTransaction_User");

            #endregion
        }

    }
}
