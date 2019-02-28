using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class CertificationProcedureMap
        : IEntityTypeConfiguration<Sca.Data.Entities.CertificationProcedure>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.CertificationProcedure> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CertificationProcedure", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CertificationId)
                .IsRequired()
                .HasColumnName("CertificationId")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("Code")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Scope)
                .HasColumnName("Scope")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Involved)
                .HasColumnName("Involved")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Active)
                .IsRequired()
                .HasColumnName("Active")
                .HasColumnType("bit");

            builder.Property(t => t.ChangeDate)
                .IsRequired()
                .HasColumnName("ChangeDate")
                .HasColumnType("datetime");

            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.PreviousVersion)
                .HasColumnName("PreviousVersion")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Certification)
                .WithMany(t => t.CertificationProcedures)
                .HasForeignKey(d => d.CertificationId)
                .HasConstraintName("FK_CertificationProcedure_Certification");

            #endregion
        }

    }
}
