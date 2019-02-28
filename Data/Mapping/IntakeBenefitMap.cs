using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class IntakeBenefitMap
        : IEntityTypeConfiguration<Sca.Data.Entities.IntakeBenefit>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.IntakeBenefit> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("IntakeBenefit", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.DateFrom)
                .HasColumnName("DateFrom")
                .HasColumnType("datetime");

            builder.Property(t => t.DateTo)
                .HasColumnName("DateTo")
                .HasColumnType("datetime");

            builder.Property(t => t.StandardAmount)
                .IsRequired()
                .HasColumnName("StandardAmount")
                .HasColumnType("decimal(8, 2)");

            builder.Property(t => t.AbsenceAmount)
                .IsRequired()
                .HasColumnName("AbsenceAmount")
                .HasColumnType("decimal(8, 2)");

            // relationships
            #endregion
        }

    }
}
