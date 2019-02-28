using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ParticipantMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Participant>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Participant> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Participant", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.AssignmentId)
                .IsRequired()
                .HasColumnName("AssignmentId")
                .HasColumnType("int");

            builder.Property(t => t.ParticipantId)
                .IsRequired()
                .HasColumnName("ParticipantId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Assignment)
                .WithMany(t => t.Participants)
                .HasForeignKey(d => d.AssignmentId)
                .HasConstraintName("FK_Participant_Assignment");

            builder.HasOne(t => t.Employee)
                .WithMany(t => t.Participants)
                .HasForeignKey(d => d.ParticipantId)
                .HasConstraintName("FK_Participant_Employee");

            #endregion
        }

    }
}
