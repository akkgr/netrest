using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class EmployeeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Employee> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Employee", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FatherLastName)
                .HasColumnName("FatherLastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FatherFirstName)
                .HasColumnName("FatherFirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.MotherLastName)
                .HasColumnName("MotherLastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.MotherFirstName)
                .HasColumnName("MotherFirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.DateOfBirth)
                .HasColumnName("DateOfBirth")
                .HasColumnType("datetime");

            builder.Property(t => t.PlaceOfBirth)
                .HasColumnName("PlaceOfBirth")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Afm)
                .HasColumnName("AFM")
                .HasColumnType("nvarchar(9)")
                .HasMaxLength(9);

            builder.Property(t => t.HireDate)
                .HasColumnName("HireDate")
                .HasColumnType("datetime");

            builder.Property(t => t.MaritalStatusId)
                .HasColumnName("MaritalStatusId")
                .HasColumnType("int");

            builder.Property(t => t.Children)
                .HasColumnName("Children")
                .HasColumnType("int");

            builder.Property(t => t.EducationId)
                .HasColumnName("EducationId")
                .HasColumnType("int");

            builder.Property(t => t.EducationRemarks)
                .HasColumnName("EducationRemarks")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.SpecialtyId)
                .HasColumnName("SpecialtyId")
                .HasColumnType("int");

            builder.Property(t => t.PositionId)
                .HasColumnName("PositionId")
                .HasColumnType("int");

            builder.Property(t => t.WorkExperience)
                .HasColumnName("WorkExperience")
                .HasColumnType("int");

            builder.Property(t => t.IndustryExperience)
                .HasColumnName("IndustryExperience")
                .HasColumnType("int");

            builder.Property(t => t.Address)
                .HasColumnName("Address")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.City)
                .HasColumnName("City")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.PostCode)
                .HasColumnName("PostCode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.HomePhone)
                .HasColumnName("HomePhone")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.MobilePhone)
                .HasColumnName("MobilePhone")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.DOYId)
                .HasColumnName("DOYId")
                .HasColumnType("int");

            builder.Property(t => t.NationalityId)
                .HasColumnName("NationalityId")
                .HasColumnType("int");

            builder.Property(t => t.IdCard)
                .HasColumnName("IdCard")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.IdCardDate)
                .HasColumnName("IdCardDate")
                .HasColumnType("datetime");

            builder.Property(t => t.AlienCard)
                .HasColumnName("AlienCard")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.AlienPass)
                .HasColumnName("AlienPass")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FirstEmployment)
                .HasColumnName("FirstEmployment")
                .HasColumnType("bit");

            builder.Property(t => t.EmploymentTypeId)
                .HasColumnName("EmploymentTypeId")
                .HasColumnType("int");

            builder.Property(t => t.ContractTypeId)
                .HasColumnName("ContractTypeId")
                .HasColumnType("int");

            builder.Property(t => t.Contract)
                .HasColumnName("Contract")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ContractUntil)
                .HasColumnName("ContractUntil")
                .HasColumnType("datetime");

            builder.Property(t => t.ResignDate)
                .HasColumnName("ResignDate")
                .HasColumnType("datetime");

            builder.Property(t => t.ResignRemarks)
                .HasColumnName("ResignRemarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.DismissalDate)
                .HasColumnName("DismissalDate")
                .HasColumnType("datetime");

            builder.Property(t => t.DismissalRemarks)
                .HasColumnName("DismissalRemarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ChangeRemarks)
                .HasColumnName("ChangeRemarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RollingSchedule)
                .HasColumnName("RollingSchedule")
                .HasColumnType("bit");

            builder.Property(t => t.ScheduleRemarks)
                .HasColumnName("ScheduleRemarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Oaed)
                .HasColumnName("OAED")
                .HasColumnType("bit");

            builder.Property(t => t.MainJob)
                .HasColumnName("MainJob")
                .HasColumnType("bit");

            builder.Property(t => t.SecondaryJob)
                .HasColumnName("SecondaryJob")
                .HasColumnType("bit");

            builder.Property(t => t.FirstInsuranceYear)
                .HasColumnName("FirstInsuranceYear")
                .HasColumnType("int");

            builder.Property(t => t.InsuranceNumber)
                .HasColumnName("InsuranceNumber")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Amka)
                .HasColumnName("AMKA")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Salary)
                .HasColumnName("Salary")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SalaryExtra)
                .HasColumnName("SalaryExtra")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.EducationCopies)
                .HasColumnName("EducationCopies")
                .HasColumnType("bit");

            builder.Property(t => t.EmploymentCopies)
                .HasColumnName("EmploymentCopies")
                .HasColumnType("bit");

            builder.Property(t => t.MaritalStatusCopies)
                .HasColumnName("MaritalStatusCopies")
                .HasColumnType("bit");

            builder.Property(t => t.Copies)
                .HasColumnName("Copies")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Kad)
                .HasColumnName("KAD")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SpecialtyCode)
                .HasColumnName("SpecialtyCode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.InsurancePack)
                .HasColumnName("InsurancePack")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SpecialInsurance)
                .HasColumnName("SpecialInsurance")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.BarCode)
                .HasColumnName("BarCode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SecRank)
                .HasColumnName("SecRank")
                .HasColumnType("int")
                .HasDefaultValueSql("((0))");

            builder.Property(t => t.Languages)
                .HasColumnName("Languages")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Bank)
                .HasColumnName("Bank")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.BankAccount)
                .HasColumnName("BankAccount")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Photo)
                .HasColumnName("Photo")
                .HasColumnType("varbinary(max)");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.RemarksAdmin)
                .HasColumnName("RemarksAdmin")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Notes)
                .HasColumnName("Notes")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.ContractType)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.ContractTypeId)
                .HasConstraintName("FK_Employee_ContractType");

            builder.HasOne(t => t.SecRankDocRank)
                .WithMany(t => t.SecRankEmployees)
                .HasForeignKey(d => d.SecRank)
                .HasConstraintName("FK_Employee_DocRank");

            builder.HasOne(t => t.Doy)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.DOYId)
                .HasConstraintName("FK_Employee_DOY");

            builder.HasOne(t => t.Education)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.EducationId)
                .HasConstraintName("FK_Employee_Education");

            builder.HasOne(t => t.EmploymentType)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.EmploymentTypeId)
                .HasConstraintName("FK_Employee_EmploymentType");

            builder.HasOne(t => t.StatusMarital)
                .WithMany(t => t.StatusEmployees)
                .HasForeignKey(d => d.MaritalStatusId)
                .HasConstraintName("FK_Employee_Marital");

            builder.HasOne(t => t.Nationality)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.NationalityId)
                .HasConstraintName("FK_Employee_Nationality");

            builder.HasOne(t => t.Specialty)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.SpecialtyId)
                .HasConstraintName("FK_Employee_Specialty");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Employee_User");

            builder.HasOne(t => t.PositionWorkPosition)
                .WithMany(t => t.PositionEmployees)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_Employee_WorkPosition");

            #endregion
        }

    }
}
