using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class AppointmentIntakeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.AppointmentIntake>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.AppointmentIntake> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AppointmentIntake", "dbo");

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

            builder.Property(t => t.IsIntake)
                .IsRequired()
                .HasColumnName("IsIntake")
                .HasColumnType("bit");

            builder.Property(t => t.IntakeId)
                .HasColumnName("IntakeId")
                .HasColumnType("int");

            builder.Property(t => t.IsClient)
                .IsRequired()
                .HasColumnName("IsClient")
                .HasColumnType("bit");

            builder.Property(t => t.ClientId)
                .HasColumnName("ClientId")
                .HasColumnType("int");

            builder.Property(t => t.FullName)
                .HasColumnName("FullName")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.RankId)
                .HasColumnName("RankId")
                .HasColumnType("int");

            builder.Property(t => t.Billed)
                .IsRequired()
                .HasColumnName("Billed")
                .HasColumnType("bit");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Appointment)
                .WithMany(t => t.AppointmentIntakes)
                .HasForeignKey(d => d.AppointmentId)
                .HasConstraintName("FK_AppointmentIntake_Appointment");

            builder.HasOne(t => t.Client)
                .WithMany(t => t.AppointmentIntakes)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_AppointmentIntake_Client");

            builder.HasOne(t => t.RankDocRank)
                .WithMany(t => t.RankAppointmentIntakes)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("FK_AppointmentIntake_DocRank");

            builder.HasOne(t => t.Intake)
                .WithMany(t => t.AppointmentIntakes)
                .HasForeignKey(d => d.IntakeId)
                .HasConstraintName("FK_AppointmentIntake_Intake");

            #endregion
        }

    }
}
