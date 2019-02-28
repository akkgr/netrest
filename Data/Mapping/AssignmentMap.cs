using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class AssignmentMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Assignment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Assignment> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Assignment", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.OwnerId)
                .IsRequired()
                .HasColumnName("OwnerId")
                .HasColumnType("int");

            builder.Property(t => t.Subject)
                .HasColumnName("Subject")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .IsRequired()
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.ScheduleType)
                .IsRequired()
                .HasColumnName("ScheduleType")
                .HasColumnType("int");

            builder.Property(t => t.RecurrenceInfo)
                .HasColumnName("RecurrenceInfo")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ResponsibleId)
                .IsRequired()
                .HasColumnName("ResponsibleId")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Result)
                .HasColumnName("Result")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Progress)
                .IsRequired()
                .HasColumnName("Progress")
                .HasColumnType("decimal(5, 2)");

            builder.Property(t => t.Completed)
                .IsRequired()
                .HasColumnName("Completed")
                .HasColumnType("bit");

            builder.Property(t => t.HasPermission)
                .IsRequired()
                .HasColumnName("HasPermission")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.ClientId)
                .HasColumnName("ClientId")
                .HasColumnType("int");

            builder.Property(t => t.IntakeId)
                .HasColumnName("IntakeId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Client)
                .WithMany(t => t.Assignments)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_Assignment_Client");

            builder.HasOne(t => t.Intake)
                .WithMany(t => t.Assignments)
                .HasForeignKey(d => d.IntakeId)
                .HasConstraintName("FK_Assignment_Intake");

            builder.HasOne(t => t.OwnerEmployee)
                .WithMany(t => t.OwnerAssignments)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_Assignment_Owner");

            builder.HasOne(t => t.ResponsibleEmployee)
                .WithMany(t => t.ResponsibleAssignments)
                .HasForeignKey(d => d.ResponsibleId)
                .HasConstraintName("FK_Assignment_Responsible");

            #endregion
        }

    }
}
