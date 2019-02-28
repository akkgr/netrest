using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class DepartmentFlowChartMap
        : IEntityTypeConfiguration<Sca.Data.Entities.DepartmentFlowChart>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.DepartmentFlowChart> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DepartmentFlowChart", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.DepartmentId)
                .IsRequired()
                .HasColumnName("DepartmentId")
                .HasColumnType("int");

            builder.Property(t => t.FlowChartId)
                .IsRequired()
                .HasColumnName("FlowChartId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Department)
                .WithMany(t => t.DepartmentFlowCharts)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DepartmentFlowChart_Department");

            builder.HasOne(t => t.FlowChart)
                .WithMany(t => t.DepartmentFlowCharts)
                .HasForeignKey(d => d.FlowChartId)
                .HasConstraintName("FK_DepartmentFlowChart_FlowChart");

            #endregion
        }

    }
}
