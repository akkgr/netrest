using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class UserOrgMap
        : IEntityTypeConfiguration<Sca.Data.Entities.UserOrg>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.UserOrg> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("UserOrg", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.CanAdd)
                .HasColumnName("CanAdd")
                .HasColumnType("bit");

            builder.Property(t => t.CanDelete)
                .HasColumnName("CanDelete")
                .HasColumnType("bit");

            builder.Property(t => t.CanEdit)
                .HasColumnName("CanEdit")
                .HasColumnType("bit");

            builder.Property(t => t.CanExport)
                .HasColumnName("CanExport")
                .HasColumnType("bit");

            builder.Property(t => t.CanPrint)
                .HasColumnName("CanPrint")
                .HasColumnType("bit");

            builder.Property(t => t.CanDoSpecial)
                .HasColumnName("CanDoSpecial")
                .HasColumnType("bit");

            builder.Property(t => t.Supervisor)
                .HasColumnName("Supervisor")
                .HasColumnType("bit");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.User)
                .WithMany(t => t.UserOrgs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserAction_User");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.UserOrgs)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_UserPermission_OrgTreeNode");

            #endregion
        }

    }
}
