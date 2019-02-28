using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class DivisionJobMap
        : IEntityTypeConfiguration<Sca.Data.Entities.DivisionJob>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.DivisionJob> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DivisionJob", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.DivisionId)
                .IsRequired()
                .HasColumnName("DivisionId")
                .HasColumnType("int");

            builder.Property(t => t.ChangeDate)
                .IsRequired()
                .HasColumnName("ChangeDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Job)
                .IsRequired()
                .HasColumnName("Job")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Division)
                .WithMany(t => t.DivisionJobs)
                .HasForeignKey(d => d.DivisionId)
                .HasConstraintName("FK_DivisionJob_Division");

            #endregion
        }

    }
}
