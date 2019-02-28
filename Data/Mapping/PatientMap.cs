using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class PatientMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Patient>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Patient> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Patient", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(t => t.PopulationCategory)
                .HasColumnName("PopulationCategory")
                .HasColumnType("int");

            builder.Property(t => t.PopulationCategoryNote)
                .HasColumnName("PopulationCategoryNote")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.OtherProgram)
                .HasColumnName("OtherProgram")
                .HasColumnType("bit");

            builder.Property(t => t.OtherProgramNote)
                .HasColumnName("OtherProgramNote")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Diagnosis)
                .HasColumnName("Diagnosis")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.DoubleDiagnosis)
                .HasColumnName("DoubleDiagnosis")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Medication)
                .HasColumnName("Medication")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.DrugRelation)
                .HasColumnName("DrugRelation")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Doctor)
                .HasColumnName("Doctor")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.DoctorRelation)
                .HasColumnName("DoctorRelation")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.FunctionalLevels)
                .HasColumnName("FunctionalLevels")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Rehabilitation)
                .HasColumnName("Rehabilitation")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Willingness)
                .HasColumnName("Willingness")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Cooperation)
                .HasColumnName("Cooperation")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.OtherTherapist)
                .HasColumnName("OtherTherapist")
                .HasColumnType("bit");

            builder.Property(t => t.OtherTherapistNote)
                .HasColumnName("OtherTherapistNote")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.MultiTeam)
                .HasColumnName("MultiTeam")
                .HasColumnType("bit");

            builder.Property(t => t.MultiTeamNote)
                .HasColumnName("MultiTeamNote")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.OtherAgency)
                .HasColumnName("OtherAgency")
                .HasColumnType("bit");

            builder.Property(t => t.OtherAgencyNote)
                .HasColumnName("OtherAgencyNote")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.FreeTimeActivities)
                .HasColumnName("FreeTimeActivities")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.DoctorName)
                .HasColumnName("DoctorName")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.DoctorAMKA)
                .HasColumnName("DoctorAMKA")
                .HasColumnType("nvarchar(11)")
                .HasMaxLength(11);

            builder.Property(t => t.DiseaseId)
                .HasColumnName("DiseaseId")
                .HasColumnType("int");

            builder.Property(t => t.SecondDiseaseId)
                .HasColumnName("SecondDiseaseId")
                .HasColumnType("int");

            builder.Property(t => t.ThirdDiseaseId)
                .HasColumnName("ThirdDiseaseId")
                .HasColumnType("int");

            builder.Property(t => t.Recursions)
                .HasColumnName("Recursions")
                .HasColumnType("int");

            builder.Property(t => t.SatisfactionMeasurement)
                .HasColumnName("SatisfactionMeasurement")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SatisfactionDegree)
                .HasColumnName("SatisfactionDegree")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.TerminationReason)
                .HasColumnName("TerminationReason")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Disease)
                .WithMany(t => t.Patients)
                .HasForeignKey(d => d.DiseaseId)
                .HasConstraintName("FK_Patient_Disease");

            builder.HasOne(t => t.SecondDisease)
                .WithMany(t => t.SecondPatients)
                .HasForeignKey(d => d.SecondDiseaseId)
                .HasConstraintName("FK_Patient_Disease1");

            builder.HasOne(t => t.ThirdDisease)
                .WithMany(t => t.ThirdPatients)
                .HasForeignKey(d => d.ThirdDiseaseId)
                .HasConstraintName("FK_Patient_Disease2");

            builder.HasOne(t => t.Intake)
                .WithOne(t => t.Patient)
                .HasForeignKey<Sca.Data.Entities.Patient>(d => d.Id)
                .HasConstraintName("FK_Patient_Intake");

            #endregion
        }

    }
}
