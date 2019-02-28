using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class VolunteerMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Volunteer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Volunteer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Volunteer", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(t => t.Frequency)
                .HasColumnName("Frequency")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.FrequencyOther)
                .HasColumnName("FrequencyOther")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Ornings)
                .HasColumnName("Μornings")
                .HasColumnType("bit");

            builder.Property(t => t.Venings)
                .HasColumnName("Εvenings")
                .HasColumnType("bit");

            builder.Property(t => t.WeekEnds)
                .HasColumnName("WeekEnds")
                .HasColumnType("bit");

            builder.Property(t => t.WasMember)
                .HasColumnName("WasMember")
                .HasColumnType("bit");

            builder.Property(t => t.Period)
                .HasColumnName("Period")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Objective)
                .HasColumnName("Objective")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Training)
                .HasColumnName("Training")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.TrainingOther)
                .HasColumnName("TrainingOther")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.AreasOfInterest)
                .HasColumnName("AreasOfInterest")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.AreasOfInterestOther)
                .HasColumnName("AreasOfInterestOther")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Health)
                .HasColumnName("Health")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Intake)
                .WithOne(t => t.Volunteer)
                .HasForeignKey<Sca.Data.Entities.Volunteer>(d => d.Id)
                .HasConstraintName("FK_Volunteer_Intake");

            #endregion
        }

    }
}
