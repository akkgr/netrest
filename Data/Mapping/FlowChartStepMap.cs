using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class FlowChartStepMap
        : IEntityTypeConfiguration<Sca.Data.Entities.FlowChartStep>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.FlowChartStep> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("FlowChartStep", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.FlowChartId)
                .IsRequired()
                .HasColumnName("FlowChartId")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.FlowChart)
                .WithMany(t => t.FlowChartSteps)
                .HasForeignKey(d => d.FlowChartId)
                .HasConstraintName("FK_FlowChartStep_FlowChart");

            #endregion
        }

    }
}
