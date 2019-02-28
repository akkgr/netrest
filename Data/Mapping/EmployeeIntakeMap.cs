using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class EmployeeIntakeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.EmployeeIntake>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.EmployeeIntake> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("EmployeeIntake", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.EmployeeId)
                .IsRequired()
                .HasColumnName("EmployeeId")
                .HasColumnType("int");

            builder.Property(t => t.IntakeId)
                .IsRequired()
                .HasColumnName("IntakeId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.DateFrom)
                .IsRequired()
                .HasColumnName("DateFrom")
                .HasColumnType("datetime");

            builder.Property(t => t.DateTo)
                .HasColumnName("DateTo")
                .HasColumnType("datetime");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.EmployeeIntakes)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_EmployeeIntake_Employee");

            builder.HasOne(t => t.Intake)
                .WithMany(t => t.EmployeeIntakes)
                .HasForeignKey(d => d.IntakeId)
                .HasConstraintName("FK_EmployeeIntake_Intake");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.EmployeeIntakes)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_EmployeeIntake_OrgTreeNode");

            #endregion
        }

    }
}
