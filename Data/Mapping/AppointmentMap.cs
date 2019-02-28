using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class AppointmentMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Appointment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Appointment> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Appointment", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.AppointmentTypeId)
                .HasColumnName("AppointmentTypeId")
                .HasColumnType("int");

            builder.Property(t => t.Subject)
                .HasColumnName("Subject")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.DateStart)
                .IsRequired()
                .HasColumnName("DateStart")
                .HasColumnType("datetime");

            builder.Property(t => t.DateEnd)
                .IsRequired()
                .HasColumnName("DateEnd")
                .HasColumnType("datetime");

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.AllDay)
                .IsRequired()
                .HasColumnName("AllDay")
                .HasColumnType("bit");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("int");

            builder.Property(t => t.RecurrenceInfo)
                .HasColumnName("RecurrenceInfo")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ReminderInfo)
                .HasColumnName("ReminderInfo")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ScheduleType)
                .IsRequired()
                .HasColumnName("ScheduleType")
                .HasColumnType("int");

            builder.Property(t => t.Cancelled)
                .HasColumnName("Cancelled")
                .HasColumnType("bit");

            builder.Property(t => t.CancelReason)
                .HasColumnName("CancelReason")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Occupied)
                .HasColumnName("Occupied")
                .HasColumnType("bit");

            builder.Property(t => t.WorkGroupId)
                .HasColumnName("WorkGroupId")
                .HasColumnType("int");

            builder.Property(t => t.RankId)
                .HasColumnName("RankId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.IsRegistry)
                .IsRequired()
                .HasColumnName("IsRegistry")
                .HasColumnType("bit");

            builder.Property(t => t.NoCost)
                .IsRequired()
                .HasColumnName("NoCost")
                .HasColumnType("bit");

            builder.Property(t => t.CostRemarks)
                .HasColumnName("CostRemarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.IsPrivate)
                .IsRequired()
                .HasColumnName("IsPrivate")
                .HasColumnType("bit");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.AppointmentType)
                .WithMany(t => t.Appointments)
                .HasForeignKey(d => d.AppointmentTypeId)
                .HasConstraintName("FK_Appointment_AppointmentType");

            builder.HasOne(t => t.RankDocRank)
                .WithMany(t => t.RankAppointments)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("FK_Appointment_DocRank");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Appointments)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Appointment_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Appointments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Appointment_User");

            builder.HasOne(t => t.WorkGroup)
                .WithMany(t => t.Appointments)
                .HasForeignKey(d => d.WorkGroupId)
                .HasConstraintName("FK_Appointment_WorkGroup");

            #endregion
        }

    }
}
