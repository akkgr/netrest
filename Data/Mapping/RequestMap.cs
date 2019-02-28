using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class RequestMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Request>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Request> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Request", "dbo");

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

            builder.Property(t => t.RequestTypeId)
                .IsRequired()
                .HasColumnName("RequestTypeId")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.DateFrom)
                .HasColumnName("DateFrom")
                .HasColumnType("datetime");

            builder.Property(t => t.DateTo)
                .HasColumnName("DateTo")
                .HasColumnType("datetime");

            builder.Property(t => t.DaysEmployee)
                .HasColumnName("DaysEmployee")
                .HasColumnType("int");

            builder.Property(t => t.DaysSupervisor)
                .HasColumnName("DaysSupervisor")
                .HasColumnType("int");

            builder.Property(t => t.ForYear)
                .HasColumnName("ForYear")
                .HasColumnType("int");

            builder.Property(t => t.DateApplied)
                .HasColumnName("DateApplied")
                .HasColumnType("datetime");

            builder.Property(t => t.Pending)
                .IsRequired()
                .HasColumnName("Pending")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.Approved)
                .IsRequired()
                .HasColumnName("Approved")
                .HasColumnType("bit");

            builder.Property(t => t.ApprovedById)
                .HasColumnName("ApprovedById")
                .HasColumnType("int");

            builder.Property(t => t.DateApproved)
                .HasColumnName("DateApproved")
                .HasColumnType("datetime");

            builder.Property(t => t.Answer)
                .HasColumnName("Answer")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Category)
                .IsRequired()
                .HasColumnName("Category")
                .HasColumnType("int");

            builder.Property(t => t.Received)
                .IsRequired()
                .HasColumnName("Received")
                .HasColumnType("bit");

            builder.Property(t => t.Deadline)
                .HasColumnName("Deadline")
                .HasColumnType("datetime");

            builder.Property(t => t.AssignmentId)
                .HasColumnName("AssignmentId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Assignment)
                .WithMany(t => t.Requests)
                .HasForeignKey(d => d.AssignmentId)
                .HasConstraintName("FK_Request_Assignment");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Requests)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Request_OrgTreeNode");

            builder.HasOne(t => t.RequestType)
                .WithMany(t => t.Requests)
                .HasForeignKey(d => d.RequestTypeId)
                .HasConstraintName("FK_Request_RequestType");

            builder.HasOne(t => t.EmployeeUser)
                .WithMany(t => t.EmployeeRequests)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Request_User");

            builder.HasOne(t => t.ApprovedByUser)
                .WithMany(t => t.ApprovedByRequests)
                .HasForeignKey(d => d.ApprovedById)
                .HasConstraintName("FK_Request_User1");

            #endregion
        }

    }
}
