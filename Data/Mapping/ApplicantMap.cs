using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ApplicantMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Applicant>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Applicant> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Applicant", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ApplicationNumber)
                .HasColumnName("ApplicationNumber")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ApplicationCode)
                .HasColumnName("ApplicationCode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Publication)
                .HasColumnName("Publication")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.LastName)
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FatherName)
                .HasColumnName("FatherName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.MotherName)
                .HasColumnName("MotherName")
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

            builder.Property(t => t.Afm)
                .HasColumnName("AFM")
                .HasColumnType("nvarchar(9)")
                .HasMaxLength(9);

            builder.Property(t => t.Sex)
                .HasColumnName("Sex")
                .HasColumnType("int");

            builder.Property(t => t.BirthDate)
                .HasColumnName("BirthDate")
                .HasColumnType("datetime");

            builder.Property(t => t.City)
                .HasColumnName("City")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Address)
                .HasColumnName("Address")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StreetNumber)
                .HasColumnName("StreetNumber")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.PostalCode)
                .HasColumnName("PostalCode")
                .HasColumnType("nvarchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.Phone)
                .HasColumnName("Phone")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Mobile)
                .HasColumnName("Mobile")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.DegreeId)
                .HasColumnName("DegreeId")
                .HasColumnType("int");

            builder.Property(t => t.SpecialtyId)
                .HasColumnName("SpecialtyId")
                .HasColumnType("int");

            builder.Property(t => t.Points)
                .HasColumnName("Points")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RemarksPublic)
                .HasColumnName("RemarksPublic")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Result)
                .HasColumnName("Result")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Photo)
                .HasColumnName("Photo")
                .HasColumnType("varbinary(max)");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Degree)
                .WithMany(t => t.Applicants)
                .HasForeignKey(d => d.DegreeId)
                .HasConstraintName("FK_Applicant_Degree");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Applicants)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Applicant_OrgTreeNode");

            builder.HasOne(t => t.Specialty)
                .WithMany(t => t.Applicants)
                .HasForeignKey(d => d.SpecialtyId)
                .HasConstraintName("FK_Applicant_Specialty");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Applicants)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Applicant_User");

            #endregion
        }

    }
}
