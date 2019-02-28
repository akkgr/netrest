using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class DepartmentCertificationMap
        : IEntityTypeConfiguration<Sca.Data.Entities.DepartmentCertification>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.DepartmentCertification> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DepartmentCertification", "dbo");

            // key
            builder.HasKey(t => new { t.DepartmentId, t.CertificationId });

            // properties
            builder.Property(t => t.DepartmentId)
                .IsRequired()
                .HasColumnName("DepartmentId")
                .HasColumnType("int");

            builder.Property(t => t.CertificationId)
                .IsRequired()
                .HasColumnName("CertificationId")
                .HasColumnType("int");

            builder.Property(t => t.CertificationStart)
                .HasColumnName("CertificationStart")
                .HasColumnType("datetime");

            builder.Property(t => t.CertificationEnd)
                .HasColumnName("CertificationEnd")
                .HasColumnType("datetime");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Certification)
                .WithMany(t => t.DepartmentCertifications)
                .HasForeignKey(d => d.CertificationId)
                .HasConstraintName("FK_DepartmentCertification_Certification");

            builder.HasOne(t => t.Department)
                .WithMany(t => t.DepartmentCertifications)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DepartmentCertification_Department");

            #endregion
        }

    }
}
