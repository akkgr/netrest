using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class CardIntakeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.CardIntake>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.CardIntake> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CardIntake", "dbo");

            // key
            builder.HasKey(t => new { t.CardId, t.IntakeId });

            // properties
            builder.Property(t => t.CardId)
                .IsRequired()
                .HasColumnName("CardId")
                .HasColumnType("int");

            builder.Property(t => t.IntakeId)
                .IsRequired()
                .HasColumnName("IntakeId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Card)
                .WithMany(t => t.CardIntakes)
                .HasForeignKey(d => d.CardId)
                .HasConstraintName("FK_CardIntake_Card");

            builder.HasOne(t => t.Intake)
                .WithMany(t => t.CardIntakes)
                .HasForeignKey(d => d.IntakeId)
                .HasConstraintName("FK_CardIntake_Intake");

            #endregion
        }

    }
}
