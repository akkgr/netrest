using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class AppointmentSpecialtyMap
        : IEntityTypeConfiguration<Sca.Data.Entities.AppointmentSpecialty>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.AppointmentSpecialty> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AppointmentSpecialty", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.AppointmentId)
                .IsRequired()
                .HasColumnName("AppointmentId")
                .HasColumnType("int");

            builder.Property(t => t.WorkPositionId)
                .IsRequired()
                .HasColumnName("WorkPositionId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Appointment)
                .WithMany(t => t.AppointmentSpecialties)
                .HasForeignKey(d => d.AppointmentId)
                .HasConstraintName("FK_AppointmentSpecialty_Appointment");

            builder.HasOne(t => t.WorkPosition)
                .WithMany(t => t.AppointmentSpecialties)
                .HasForeignKey(d => d.WorkPositionId)
                .HasConstraintName("FK_AppointmentSpecialty_WorkPosition");

            #endregion
        }

    }
}
