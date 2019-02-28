using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class CertificationProcedurePublicationMap
        : IEntityTypeConfiguration<Sca.Data.Entities.CertificationProcedurePublication>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.CertificationProcedurePublication> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CertificationProcedurePublication", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ProcedureId)
                .IsRequired()
                .HasColumnName("ProcedureId")
                .HasColumnType("int");

            builder.Property(t => t.PublicationId)
                .IsRequired()
                .HasColumnName("PublicationId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.ProcedureCertificationProcedure)
                .WithMany(t => t.ProcedureCertificationProcedurePublications)
                .HasForeignKey(d => d.ProcedureId)
                .HasConstraintName("FK_CertificationProcedurePublication_CertificationProcedure");

            builder.HasOne(t => t.Publication)
                .WithMany(t => t.CertificationProcedurePublications)
                .HasForeignKey(d => d.PublicationId)
                .HasConstraintName("FK_CertificationProcedurePublication_Publication");

            #endregion
        }

    }
}
