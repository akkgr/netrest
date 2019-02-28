using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class IntakeAbsenceMap
        : IEntityTypeConfiguration<Sca.Data.Entities.IntakeAbsence>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.IntakeAbsence> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("IntakeAbsence", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IntakeId)
                .IsRequired()
                .HasColumnName("IntakeId")
                .HasColumnType("int");

            builder.Property(t => t.FromDate)
                .IsRequired()
                .HasColumnName("FromDate")
                .HasColumnType("datetime");

            builder.Property(t => t.ToDate)
                .IsRequired()
                .HasColumnName("ToDate")
                .HasColumnType("datetime");

            builder.Property(t => t.TypeId)
                .IsRequired()
                .HasColumnName("TypeId")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Intake)
                .WithMany(t => t.IntakeAbsences)
                .HasForeignKey(d => d.IntakeId)
                .HasConstraintName("FK_IntakeAbsence_Intake");

            builder.HasOne(t => t.TypeIntakeAbsenceType)
                .WithMany(t => t.TypeIntakeAbsences)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_IntakeAbsence_IntakeAbsenceType");

            #endregion
        }

    }
}
