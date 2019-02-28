using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class EmployeeOrgMap
        : IEntityTypeConfiguration<Sca.Data.Entities.EmployeeOrg>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.EmployeeOrg> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("EmployeeOrg", "dbo");

            // key
            builder.HasKey(t => new { t.OrgTreeNodeId, t.EmployeeId });

            // properties
            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.EmployeeId)
                .IsRequired()
                .HasColumnName("EmployeeId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.EmployeeOrgs)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_EmployeeOrg_Employee");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.EmployeeOrgs)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_EmployeeOrg_OrgTreeNode");

            #endregion
        }

    }
}
