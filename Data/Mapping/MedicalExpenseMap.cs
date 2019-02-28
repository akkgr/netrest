using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class MedicalExpenseMap
        : IEntityTypeConfiguration<Sca.Data.Entities.MedicalExpense>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.MedicalExpense> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("MedicalExpense", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(t => t.InsurerId)
                .IsRequired()
                .HasColumnName("InsurerId")
                .HasColumnType("int");

            builder.Property(t => t.Year)
                .IsRequired()
                .HasColumnName("Year")
                .HasColumnType("int");

            builder.Property(t => t.Month)
                .IsRequired()
                .HasColumnName("Month")
                .HasColumnType("int");

            builder.Property(t => t.Discount)
                .IsRequired()
                .HasColumnName("Discount")
                .HasColumnType("decimal(8, 2)");

            builder.Property(t => t.Retention10)
                .IsRequired()
                .HasColumnName("Retention10")
                .HasColumnType("decimal(8, 2)");

            builder.Property(t => t.Mtpy)
                .IsRequired()
                .HasColumnName("Mtpy")
                .HasColumnType("decimal(8, 2)");

            builder.Property(t => t.Tax8)
                .IsRequired()
                .HasColumnName("Tax8")
                .HasColumnType("decimal(8, 2)");

            builder.Property(t => t.Tax4)
                .IsRequired()
                .HasColumnName("Tax4")
                .HasColumnType("decimal(8, 2)");

            builder.Property(t => t.InitialAmount)
                .IsRequired()
                .HasColumnName("InitialAmount")
                .HasColumnType("decimal(8, 2)");

            builder.Property(t => t.RetentionIns)
                .IsRequired()
                .HasColumnName("RetentionIns")
                .HasColumnType("decimal(8, 2)");

            builder.Property(t => t.RetentionDoy)
                .IsRequired()
                .HasColumnName("RetentionDoy")
                .HasColumnType("decimal(8, 2)");

            builder.Property(t => t.FinalAmount)
                .IsRequired()
                .HasColumnName("FinalAmount")
                .HasColumnType("decimal(8, 2)");

            builder.Property(t => t.Rebate)
                .HasColumnName("Rebate")
                .HasColumnType("decimal(8, 2)");

            builder.Property(t => t.Clawback)
                .HasColumnName("Clawback")
                .HasColumnType("decimal(8, 2)");

            builder.Property(t => t.ReceiptDate)
                .HasColumnName("ReceiptDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Collected)
                .IsRequired()
                .HasColumnName("Collected")
                .HasColumnType("bit");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Insurer)
                .WithMany(t => t.MedicalExpenses)
                .HasForeignKey(d => d.InsurerId)
                .HasConstraintName("FK_MedicalExpense_Insurer");

            builder.HasOne(t => t.Invoice)
                .WithOne(t => t.MedicalExpense)
                .HasForeignKey<Sca.Data.Entities.MedicalExpense>(d => d.Id)
                .HasConstraintName("FK_MedicalExpense_Invoice");

            #endregion
        }

    }
}
