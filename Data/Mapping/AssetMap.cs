using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class AssetMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Asset>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Asset> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Asset", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

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

            builder.Property(t => t.AssetNo)
                .HasColumnName("AssetNo")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Barcode)
                .HasColumnName("Barcode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.AssetCode)
                .HasColumnName("AssetCode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Warehouse)
                .HasColumnName("Warehouse")
                .HasColumnType("bit");

            builder.Property(t => t.Supplier)
                .HasColumnName("Supplier")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Photo)
                .HasColumnName("Photo")
                .HasColumnType("varbinary(max)");

            builder.Property(t => t.RankId)
                .HasColumnName("RankId")
                .HasColumnType("int");

            builder.Property(t => t.PersonType)
                .HasColumnName("PersonType")
                .HasColumnType("int");

            builder.Property(t => t.EmployeeId)
                .HasColumnName("EmployeeId")
                .HasColumnType("int");

            builder.Property(t => t.ClientId)
                .HasColumnName("ClientId")
                .HasColumnType("int");

            builder.Property(t => t.IntakeId)
                .HasColumnName("IntakeId")
                .HasColumnType("int");

            builder.Property(t => t.EmployeeName)
                .HasColumnName("EmployeeName")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.ChargeDate)
                .HasColumnName("ChargeDate")
                .HasColumnType("datetime");

            builder.Property(t => t.FirstOrgTreeNodeId)
                .HasColumnName("FirstOrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.AssetTypeId)
                .HasColumnName("AssetTypeId")
                .HasColumnType("int");

            builder.Property(t => t.Disposed)
                .HasColumnName("Disposed")
                .HasColumnType("bit");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.AssetType)
                .WithMany(t => t.Assets)
                .HasForeignKey(d => d.AssetTypeId)
                .HasConstraintName("FK_Asset_AssetType");

            builder.HasOne(t => t.Client)
                .WithMany(t => t.Assets)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_Asset_Client");

            builder.HasOne(t => t.RankDocRank)
                .WithMany(t => t.RankAssets)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("FK_Asset_DocRank");

            builder.HasOne(t => t.Employee)
                .WithMany(t => t.Assets)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Asset_Employee");

            builder.HasOne(t => t.Intake)
                .WithMany(t => t.Assets)
                .HasForeignKey(d => d.IntakeId)
                .HasConstraintName("FK_Asset_Intake");

            builder.HasOne(t => t.InvoiceType)
                .WithMany(t => t.Assets)
                .HasForeignKey(d => d.InvoiceTypeId)
                .HasConstraintName("FK_Asset_InvoiceType");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Assets)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Asset_OrgTreeNode");

            builder.HasOne(t => t.FirstOrgTreeNode)
                .WithMany(t => t.FirstAssets)
                .HasForeignKey(d => d.FirstOrgTreeNodeId)
                .HasConstraintName("FK_Asset_OrgTreeNode1");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Assets)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Asset_User");

            #endregion
        }

    }
}
