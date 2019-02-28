using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class PublicationDivisionMap
        : IEntityTypeConfiguration<Sca.Data.Entities.PublicationDivision>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.PublicationDivision> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PublicationDivision", "dbo");

            // key
            builder.HasKey(t => new { t.PublicationId, t.DivisionId });

            // properties
            builder.Property(t => t.PublicationId)
                .IsRequired()
                .HasColumnName("PublicationId")
                .HasColumnType("int");

            builder.Property(t => t.DivisionId)
                .IsRequired()
                .HasColumnName("DivisionId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Division)
                .WithMany(t => t.PublicationDivisions)
                .HasForeignKey(d => d.DivisionId)
                .HasConstraintName("FK_PublicationDivision_Division");

            builder.HasOne(t => t.Publication)
                .WithMany(t => t.PublicationDivisions)
                .HasForeignKey(d => d.PublicationId)
                .HasConstraintName("FK_PublicationDivision_Publication");

            #endregion
        }

    }
}
