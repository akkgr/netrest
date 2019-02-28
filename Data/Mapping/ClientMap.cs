using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ClientMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Client>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Client> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Client", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.DateIn)
                .IsRequired()
                .HasColumnName("DateIn")
                .HasColumnType("datetime");

            builder.Property(t => t.Referral)
                .HasColumnName("Referral")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.MotherName)
                .HasColumnName("MotherName")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.FatherName)
                .HasColumnName("FatherName")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.InsurerId)
                .HasColumnName("InsurerId")
                .HasColumnType("int");

            builder.Property(t => t.Amka)
                .HasColumnName("AMKA")
                .HasColumnType("nvarchar(11)")
                .HasMaxLength(11);

            builder.Property(t => t.Amy)
                .HasColumnName("AMY")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Afm)
                .HasColumnName("AFM")
                .HasColumnType("nvarchar(9)")
                .HasMaxLength(9);

            builder.Property(t => t.BirthDate)
                .HasColumnName("BirthDate")
                .HasColumnType("date");

            builder.Property(t => t.MaritalStatusId)
                .HasColumnName("MaritalStatusId")
                .HasColumnType("int");

            builder.Property(t => t.IncomeId)
                .HasColumnName("IncomeId")
                .HasColumnType("int");

            builder.Property(t => t.IncomeRemarks)
                .HasColumnName("IncomeRemarks")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Sex)
                .HasColumnName("Sex")
                .HasColumnType("int");

            builder.Property(t => t.EducationId)
                .HasColumnName("EducationId")
                .HasColumnType("int");

            builder.Property(t => t.Address)
                .HasColumnName("Address")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.StayAreaId)
                .HasColumnName("StayAreaId")
                .HasColumnType("int");

            builder.Property(t => t.House)
                .HasColumnName("House")
                .HasColumnType("int");

            builder.Property(t => t.RegisterAreaId)
                .HasColumnName("RegisterAreaId")
                .HasColumnType("int");

            builder.Property(t => t.Phone)
                .HasColumnName("Phone")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Job)
                .HasColumnName("Job")
                .HasColumnType("int");

            builder.Property(t => t.JobComment)
                .HasColumnName("JobComment")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Ealth)
                .HasColumnName("Ηealth")
                .HasColumnType("int");

            builder.Property(t => t.HealthComment)
                .HasColumnName("HealthComment")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.ValidUntil)
                .HasColumnName("ValidUntil")
                .HasColumnType("date");

            builder.Property(t => t.Active)
                .HasColumnName("Active")
                .HasColumnType("int");

            builder.Property(t => t.WorkYears)
                .HasColumnName("WorkYears")
                .HasColumnType("int");

            builder.Property(t => t.NoWorkYears)
                .HasColumnName("NoWorkYears")
                .HasColumnType("int");

            builder.Property(t => t.ReferenceTo)
                .HasColumnName("ReferenceTo")
                .HasColumnType("int");

            builder.Property(t => t.ReferenceToComment)
                .HasColumnName("ReferenceToComment")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.EKOId)
                .HasColumnName("EKOId")
                .HasColumnType("int");

            builder.Property(t => t.Comment)
                .HasColumnName("Comment")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.BarCode)
                .HasColumnName("BarCode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.Domestic)
                .HasColumnName("Domestic")
                .HasColumnType("bit");

            builder.Property(t => t.Photo)
                .HasColumnName("Photo")
                .HasColumnType("varbinary(max)");

            builder.Property(t => t.RealEstate)
                .HasColumnName("RealEstate")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.Loan)
                .HasColumnName("Loan")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.IdCard)
                .HasColumnName("IdCard")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StayPermit)
                .HasColumnName("StayPermit")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StayPermitDuration)
                .HasColumnName("StayPermitDuration")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.DependentsIncome)
                .HasColumnName("DependentsIncome")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Members)
                .HasColumnName("Members")
                .HasColumnType("int");

            builder.Property(t => t.MaleMembers)
                .HasColumnName("MaleMembers")
                .HasColumnType("int");

            builder.Property(t => t.FemaleMembers)
                .HasColumnName("FemaleMembers")
                .HasColumnType("int");

            builder.Property(t => t.Children)
                .HasColumnName("Children")
                .HasColumnType("int");

            builder.Property(t => t.ChildrenAbove14)
                .HasColumnName("ChildrenAbove14")
                .HasColumnType("int");

            builder.Property(t => t.Mobile)
                .HasColumnName("Mobile")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.ActiveClientStatuses)
                .WithMany(t => t.ActiveClients)
                .HasForeignKey(d => d.Active)
                .HasConstraintName("FK_Client_ClientStatuses");

            builder.HasOne(t => t.Education)
                .WithMany(t => t.Clients)
                .HasForeignKey(d => d.EducationId)
                .HasConstraintName("FK_Client_Education");

            builder.HasOne(t => t.Eko)
                .WithMany(t => t.Clients)
                .HasForeignKey(d => d.EKOId)
                .HasConstraintName("FK_Client_EKO");

            builder.HasOne(t => t.Income)
                .WithMany(t => t.Clients)
                .HasForeignKey(d => d.IncomeId)
                .HasConstraintName("FK_Client_Income");

            builder.HasOne(t => t.Insurer)
                .WithMany(t => t.Clients)
                .HasForeignKey(d => d.InsurerId)
                .HasConstraintName("FK_Client_Insurer");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Clients)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Client_OrgTreeNode");

            builder.HasOne(t => t.RegisterAreaCounty)
                .WithMany(t => t.RegisterAreaClients)
                .HasForeignKey(d => d.RegisterAreaId)
                .HasConstraintName("FK_Client_Register");

            builder.HasOne(t => t.StayAreaCounty)
                .WithMany(t => t.StayAreaClients)
                .HasForeignKey(d => d.StayAreaId)
                .HasConstraintName("FK_Client_Stay");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Clients)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Client_User");

            builder.HasOne(t => t.StatusMarital)
                .WithMany(t => t.StatusClients)
                .HasForeignKey(d => d.MaritalStatusId)
                .HasConstraintName("FK_Client_ΜaritalStatus");

            #endregion
        }

    }
}
