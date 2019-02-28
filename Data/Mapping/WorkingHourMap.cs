using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class WorkingHourMap
        : IEntityTypeConfiguration<Sca.Data.Entities.WorkingHour>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.WorkingHour> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("WorkingHour", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.EmployeeId)
                .IsRequired()
                .HasColumnName("EmployeeId")
                .HasColumnType("int");

            builder.Property(t => t.Year)
                .IsRequired()
                .HasColumnName("Year")
                .HasColumnType("int");

            builder.Property(t => t.Month)
                .IsRequired()
                .HasColumnName("Month")
                .HasColumnType("int");

            builder.Property(t => t.Day)
                .IsRequired()
                .HasColumnName("Day")
                .HasColumnType("int");

            builder.Property(t => t.WeekDay)
                .IsRequired()
                .HasColumnName("WeekDay")
                .HasColumnType("int");

            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime2(0)");

            builder.Property(t => t.EndDate)
                .IsRequired()
                .HasColumnName("EndDate")
                .HasColumnType("datetime2(0)");

            // relationships
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.WorkingHours)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_WorkingHour_Employee");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.WorkingHours)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_WorkingHour_OrgTreeNode");

            #endregion
        }

    }
}
