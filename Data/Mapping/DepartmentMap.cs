using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class DepartmentMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Department> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Department", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.OperationStart)
                .IsRequired()
                .HasColumnName("OperationStart")
                .HasColumnType("datetime");

            builder.Property(t => t.OperationEnd)
                .HasColumnName("OperationEnd")
                .HasColumnType("datetime");

            builder.Property(t => t.RootId)
                .HasColumnName("RootId")
                .HasColumnType("int");

            builder.Property(t => t.ParentId)
                .HasColumnName("ParentId")
                .HasColumnType("int");

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Active)
                .IsRequired()
                .HasColumnName("Active")
                .HasColumnType("bit");

            builder.Property(t => t.Procedures)
                .HasColumnName("Procedures")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ChangeDate)
                .HasColumnName("ChangeDate")
                .HasColumnType("datetime");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.PreviousVersion)
                .HasColumnName("PreviousVersion")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.ParentDepartment)
                .WithMany(t => t.ParentDepartments)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Department_Department");

            builder.HasOne(t => t.RootDepartment)
                .WithMany(t => t.RootDepartments)
                .HasForeignKey(d => d.RootId)
                .HasConstraintName("FK_Department_Department1");

            #endregion
        }

    }
}
