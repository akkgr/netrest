using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class IntakePlanMap
        : IEntityTypeConfiguration<Sca.Data.Entities.IntakePlan>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.IntakePlan> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("IntakePlan", "dbo");

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

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.FromDate)
                .IsRequired()
                .HasColumnName("FromDate")
                .HasColumnType("datetime");

            builder.Property(t => t.ToDate)
                .IsRequired()
                .HasColumnName("ToDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EducationId)
                .HasColumnName("EducationId")
                .HasColumnType("int");

            builder.Property(t => t.MaritalStatusId)
                .HasColumnName("MaritalStatusId")
                .HasColumnType("int");

            builder.Property(t => t.Job)
                .HasColumnName("Job")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ContractDate)
                .HasColumnName("ContractDate")
                .HasColumnType("datetime");

            builder.Property(t => t.ContractRenewal1)
                .HasColumnName("ContractRenewal1")
                .HasColumnType("datetime");

            builder.Property(t => t.ContractRenewal2)
                .HasColumnName("ContractRenewal2")
                .HasColumnType("datetime");

            builder.Property(t => t.ContractRenewal3)
                .HasColumnName("ContractRenewal3")
                .HasColumnType("datetime");

            builder.Property(t => t.MainDiagnosis)
                .HasColumnName("MainDiagnosis")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.SecondaryDiagnosis)
                .HasColumnName("SecondaryDiagnosis")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Medication)
                .HasColumnName("Medication")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Doctor)
                .HasColumnName("Doctor")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Nurses)
                .HasColumnName("Nurses")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.LastRelapse)
                .HasColumnName("LastRelapse")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.DiseaseStart)
                .HasColumnName("DiseaseStart")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Other)
                .HasColumnName("Other")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ClinicalFocus)
                .HasColumnName("ClinicalFocus")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Evaluation)
                .HasColumnName("Evaluation")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Psychometric)
                .HasColumnName("Psychometric")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.SelfPlan)
                .HasColumnName("SelfPlan")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.FamilyPlan)
                .HasColumnName("FamilyPlan")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Education)
                .WithMany(t => t.IntakePlans)
                .HasForeignKey(d => d.EducationId)
                .HasConstraintName("FK_IntakePlan_Education");

            builder.HasOne(t => t.Intake)
                .WithMany(t => t.IntakePlans)
                .HasForeignKey(d => d.IntakeId)
                .HasConstraintName("FK_IntakePlan_Intake");

            builder.HasOne(t => t.StatusMarital)
                .WithMany(t => t.StatusIntakePlans)
                .HasForeignKey(d => d.MaritalStatusId)
                .HasConstraintName("FK_IntakePlan_Marital");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.IntakePlans)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_IntakePlan_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.IntakePlans)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_IntakePlan_User");

            #endregion
        }

    }
}
