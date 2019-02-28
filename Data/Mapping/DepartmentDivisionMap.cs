using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class DepartmentDivisionMap
        : IEntityTypeConfiguration<Sca.Data.Entities.DepartmentDivision>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.DepartmentDivision> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DepartmentDivision", "dbo");

            // key
            builder.HasKey(t => new { t.DepartmentId, t.DivisionId });

            // properties
            builder.Property(t => t.DepartmentId)
                .IsRequired()
                .HasColumnName("DepartmentId")
                .HasColumnType("int");

            builder.Property(t => t.DivisionId)
                .IsRequired()
                .HasColumnName("DivisionId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Department)
                .WithMany(t => t.DepartmentDivisions)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DepartmentDivision_Department");

            builder.HasOne(t => t.Division)
                .WithMany(t => t.DepartmentDivisions)
                .HasForeignKey(d => d.DivisionId)
                .HasConstraintName("FK_DepartmentDivision_Division");

            #endregion
        }

    }
}
