using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class LeaveMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Leave>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Leave> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Leave", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.EmployeeId)
                .IsRequired()
                .HasColumnName("EmployeeId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.BsenceTypeId)
                .IsRequired()
                .HasColumnName("ΑbsenceTypeId")
                .HasColumnType("int");

            builder.Property(t => t.Year)
                .IsRequired()
                .HasColumnName("Year")
                .HasColumnType("int");

            builder.Property(t => t.Total)
                .HasColumnName("Total")
                .HasColumnType("int");

            builder.Property(t => t.Used)
                .HasColumnName("Used")
                .HasColumnType("int");

            builder.Property(t => t.Remain)
                .HasColumnName("Remain")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Leaves)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Leave_OrgTreeNode");

            builder.HasOne(t => t.BsenceTypeRequestType)
                .WithMany(t => t.BsenceTypeLeaves)
                .HasForeignKey(d => d.BsenceTypeId)
                .HasConstraintName("FK_Leave_RequestType");

            builder.HasOne(t => t.EmployeeUser)
                .WithMany(t => t.EmployeeLeaves)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Leave_User");

            #endregion
        }

    }
}
