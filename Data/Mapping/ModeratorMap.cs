using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ModeratorMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Moderator>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Moderator> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Moderator", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IsEmployee)
                .IsRequired()
                .HasColumnName("IsEmployee")
                .HasColumnType("bit");

            builder.Property(t => t.IsUser)
                .IsRequired()
                .HasColumnName("IsUser")
                .HasColumnType("bit");

            builder.Property(t => t.WorkGroupId)
                .HasColumnName("WorkGroupId")
                .HasColumnType("int");

            builder.Property(t => t.AppointmentId)
                .HasColumnName("AppointmentId")
                .HasColumnType("int");

            builder.Property(t => t.EmployeeId)
                .HasColumnName("EmployeeId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.FullName)
                .HasColumnName("FullName")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Appointment)
                .WithMany(t => t.Moderators)
                .HasForeignKey(d => d.AppointmentId)
                .HasConstraintName("FK_Moderator_Appointment");

            builder.HasOne(t => t.Employee)
                .WithMany(t => t.Moderators)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Moderator_Employee");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Moderators)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Moderator_User");

            builder.HasOne(t => t.WorkGroup)
                .WithMany(t => t.Moderators)
                .HasForeignKey(d => d.WorkGroupId)
                .HasConstraintName("FK_Moderator_WorkGroup");

            #endregion
        }

    }
}
