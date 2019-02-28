using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class EmployeePaymentMap
        : IEntityTypeConfiguration<Sca.Data.Entities.EmployeePayment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.EmployeePayment> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("EmployeePayment", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.EmployeeId)
                .IsRequired()
                .HasColumnName("EmployeeId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.PaymentTypeId)
                .IsRequired()
                .HasColumnName("PaymentTypeId")
                .HasColumnType("int");

            builder.Property(t => t.RefDate)
                .IsRequired()
                .HasColumnName("RefDate")
                .HasColumnType("date");

            builder.Property(t => t.PayDate)
                .IsRequired()
                .HasColumnName("PayDate")
                .HasColumnType("date");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.Days)
                .HasColumnName("Days")
                .HasColumnType("int");

            builder.Property(t => t.TotalEarn)
                .HasColumnName("TotalEarn")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Insurance)
                .HasColumnName("Insurance")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Fmy)
                .HasColumnName("FMY")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Oga)
                .HasColumnName("OGA")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.TotalReserve)
                .HasColumnName("TotalReserve")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Total)
                .HasColumnName("Total")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Allowance)
                .HasColumnName("Allowance")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Nstallment)
                .HasColumnName("Ιnstallment")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Dvance)
                .HasColumnName("Αdvance")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Pay)
                .HasColumnName("Pay")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Mployer)
                .HasColumnName("Εmployer")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Paid)
                .HasColumnName("Paid")
                .HasColumnType("date");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            // relationships
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.EmployeePayments)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_EmployeePayment_Employee");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.EmployeePayments)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_EmployeePayment_OrgTreeNode");

            builder.HasOne(t => t.PaymentType)
                .WithMany(t => t.EmployeePayments)
                .HasForeignKey(d => d.PaymentTypeId)
                .HasConstraintName("FK_EmployeePayment_PaymentType");

            #endregion
        }

    }
}
