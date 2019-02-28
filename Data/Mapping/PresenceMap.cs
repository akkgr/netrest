using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class PresenceMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Presence>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Presence> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Presence", "dbo");

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

            builder.Property(t => t.EntryTime)
                .IsRequired()
                .HasColumnName("EntryTime")
                .HasColumnType("datetime");

            builder.Property(t => t.ExitTime)
                .HasColumnName("ExitTime")
                .HasColumnType("datetime");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ComputerInfo)
                .HasColumnName("ComputerInfo")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.Presences)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Presence_Employee");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Presences)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Presence_OrgTreeNode");

            #endregion
        }

    }
}
