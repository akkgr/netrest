using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class CardEmployeeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.CardEmployee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.CardEmployee> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CardEmployee", "dbo");

            // key
            builder.HasKey(t => new { t.CardId, t.EmployeeId });

            // properties
            builder.Property(t => t.CardId)
                .IsRequired()
                .HasColumnName("CardId")
                .HasColumnType("int");

            builder.Property(t => t.EmployeeId)
                .IsRequired()
                .HasColumnName("EmployeeId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Card)
                .WithMany(t => t.CardEmployees)
                .HasForeignKey(d => d.CardId)
                .HasConstraintName("FK_CardEmployee_Card");

            builder.HasOne(t => t.Employee)
                .WithMany(t => t.CardEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_CardEmployee_Employee");

            #endregion
        }

    }
}
