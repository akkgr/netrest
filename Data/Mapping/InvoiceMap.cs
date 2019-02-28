using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class InvoiceMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Invoice>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Invoice> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Invoice", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.CompanyNodeId)
                .IsRequired()
                .HasColumnName("CompanyNodeId")
                .HasColumnType("int");

            builder.Property(t => t.CompanyId)
                .IsRequired()
                .HasColumnName("CompanyId")
                .HasColumnType("int");

            builder.Property(t => t.CompanyTitle)
                .IsRequired()
                .HasColumnName("CompanyTitle")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.CompanyAFM)
                .IsRequired()
                .HasColumnName("CompanyAFM")
                .HasColumnType("nvarchar(9)")
                .HasMaxLength(9);

            builder.Property(t => t.TransactionTypeId)
                .IsRequired()
                .HasColumnName("TransactionTypeId")
                .HasColumnType("int");

            builder.Property(t => t.TransactionTitle)
                .IsRequired()
                .HasColumnName("TransactionTitle")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.InvoiceTypeId)
                .IsRequired()
                .HasColumnName("InvoiceTypeId")
                .HasColumnType("int");

            builder.Property(t => t.InvoiceTitle)
                .IsRequired()
                .HasColumnName("InvoiceTitle")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.InvoiceNumber)
                .IsRequired()
                .HasColumnName("InvoiceNumber")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.InvoiceDate)
                .IsRequired()
                .HasColumnName("InvoiceDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Registered)
                .IsRequired()
                .HasColumnName("Registered")
                .HasColumnType("datetime");

            builder.Property(t => t.TotalAmount)
                .IsRequired()
                .HasColumnName("TotalAmount")
                .HasColumnType("decimal(18, 2)");

            builder.Property(t => t.RetentionSum)
                .IsRequired()
                .HasColumnName("RetentionSum")
                .HasColumnType("decimal(18, 2)");

            builder.Property(t => t.TransferAmount)
                .IsRequired()
                .HasColumnName("TransferAmount")
                .HasColumnType("decimal(18, 2)");

            builder.Property(t => t.ActivityCodeId)
                .IsRequired()
                .HasColumnName("ActivityCodeId")
                .HasColumnType("int");

            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("Code")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.CashAction)
                .IsRequired()
                .HasColumnName("CashAction")
                .HasColumnType("int")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.TraderAction)
                .IsRequired()
                .HasColumnName("TraderAction")
                .HasColumnType("int");

            builder.Property(t => t.ForTrader)
                .IsRequired()
                .HasColumnName("ForTrader")
                .HasColumnType("bit");

            builder.Property(t => t.CreditAndDebit)
                .IsRequired()
                .HasColumnName("CreditAndDebit")
                .HasColumnType("bit");

            builder.Property(t => t.IsCash)
                .IsRequired()
                .HasColumnName("IsCash")
                .HasColumnType("bit");

            builder.Property(t => t.NotInReport)
                .IsRequired()
                .HasColumnName("NotInReport")
                .HasColumnType("bit");

            builder.Property(t => t.NotInBudget)
                .IsRequired()
                .HasColumnName("NotInBudget")
                .HasColumnType("bit");

            builder.Property(t => t.DocRankId)
                .IsRequired()
                .HasColumnName("DocRankId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.ChequeNumber)
                .HasColumnName("ChequeNumber")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ChequeDate)
                .HasColumnName("ChequeDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Notes)
                .HasColumnName("Notes")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.VirtualNodeId)
                .HasColumnName("VirtualNodeId")
                .HasColumnType("int");

            builder.Property(t => t.Eep)
                .HasColumnName("EEP")
                .HasColumnType("bit");

            builder.Property(t => t.InvoiceId)
                .HasColumnName("InvoiceId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.ActivityCode)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.ActivityCodeId)
                .HasConstraintName("FK_Invoice_ActivityCode");

            builder.HasOne(t => t.Company)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Invoice_Company");

            builder.HasOne(t => t.DocRank)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.DocRankId)
                .HasConstraintName("FK_Invoice_DocRank");

            builder.HasOne(t => t.InvoiceMember)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_Invoice_Invoice");

            builder.HasOne(t => t.InvoiceType)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.InvoiceTypeId)
                .HasConstraintName("FK_Invoice_InvoiceType");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Invoice_OrgTreeNode");

            builder.HasOne(t => t.CompanyNodeOrgTreeNode)
                .WithMany(t => t.CompanyNodeInvoices)
                .HasForeignKey(d => d.CompanyNodeId)
                .HasConstraintName("FK_Invoice_OrgTreeNode1");

            builder.HasOne(t => t.VirtualNodeOrgTreeNode)
                .WithMany(t => t.VirtualNodeInvoices)
                .HasForeignKey(d => d.VirtualNodeId)
                .HasConstraintName("FK_Invoice_OrgTreeNode2");

            builder.HasOne(t => t.TransactionType)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.TransactionTypeId)
                .HasConstraintName("FK_Invoice_TransactionType");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Invoice_User");

            #endregion
        }

    }
}
