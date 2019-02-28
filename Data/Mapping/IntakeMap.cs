using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class IntakeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Intake>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Intake> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Intake", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.DateIn)
                .HasColumnName("DateIn")
                .HasColumnType("datetime");

            builder.Property(t => t.Received)
                .HasColumnName("Received")
                .HasColumnType("datetime");

            builder.Property(t => t.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.FatherName)
                .HasColumnName("FatherName")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.MotherName)
                .HasColumnName("MotherName")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.MaritalStatusId)
                .HasColumnName("MaritalStatusId")
                .HasColumnType("int");

            builder.Property(t => t.EducationId)
                .HasColumnName("EducationId")
                .HasColumnType("int");

            builder.Property(t => t.Job)
                .HasColumnName("Job")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Insurance)
                .HasColumnName("Insurance")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Afm)
                .HasColumnName("AFM")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Adt)
                .HasColumnName("ADT")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Amka)
                .HasColumnName("AMKA")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Phone)
                .HasColumnName("Phone")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Mobile)
                .HasColumnName("Mobile")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Address)
                .HasColumnName("Address")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Resident)
                .HasColumnName("Resident")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Registered)
                .HasColumnName("Registered")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Request)
                .IsRequired()
                .HasColumnName("Request")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Reference)
                .HasColumnName("Reference")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.DocRankId)
                .IsRequired()
                .HasColumnName("DocRankId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.Status)
                .HasColumnName("Status")
                .HasColumnType("int");

            builder.Property(t => t.Status0From)
                .HasColumnName("Status0From")
                .HasColumnType("datetime");

            builder.Property(t => t.Status0To)
                .HasColumnName("Status0To")
                .HasColumnType("datetime");

            builder.Property(t => t.Status1From)
                .HasColumnName("Status1From")
                .HasColumnType("datetime");

            builder.Property(t => t.Status1To)
                .HasColumnName("Status1To")
                .HasColumnType("datetime");

            builder.Property(t => t.Status2From)
                .HasColumnName("Status2From")
                .HasColumnType("datetime");

            builder.Property(t => t.Status2To)
                .HasColumnName("Status2To")
                .HasColumnType("datetime");

            builder.Property(t => t.Status3From)
                .HasColumnName("Status3From")
                .HasColumnType("datetime");

            builder.Property(t => t.Status3To)
                .HasColumnName("Status3To")
                .HasColumnType("datetime");

            builder.Property(t => t.BarCode)
                .HasColumnName("BarCode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Photo)
                .HasColumnName("Photo")
                .HasColumnType("varbinary(max)");

            builder.Property(t => t.IntakeType)
                .IsRequired()
                .HasColumnName("IntakeType")
                .HasColumnType("int");

            builder.Property(t => t.School)
                .HasColumnName("School")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.BirthDate)
                .HasColumnName("BirthDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Languages)
                .HasColumnName("Languages")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.OtherInfo)
                .HasColumnName("OtherInfo")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.Sex)
                .HasColumnName("Sex")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.DocRank)
                .WithMany(t => t.Intakes)
                .HasForeignKey(d => d.DocRankId)
                .HasConstraintName("FK_Intake_DocRank");

            builder.HasOne(t => t.Education)
                .WithMany(t => t.Intakes)
                .HasForeignKey(d => d.EducationId)
                .HasConstraintName("FK_Intake_Education");

            builder.HasOne(t => t.StatusMarital)
                .WithMany(t => t.StatusIntakes)
                .HasForeignKey(d => d.MaritalStatusId)
                .HasConstraintName("FK_Intake_Marital");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Intakes)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Intake_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Intakes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Intake_User");

            #endregion
        }

    }
}
