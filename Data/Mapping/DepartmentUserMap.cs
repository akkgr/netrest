using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class DepartmentUserMap
        : IEntityTypeConfiguration<Sca.Data.Entities.DepartmentUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.DepartmentUser> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DepartmentUser", "dbo");

            // key
            builder.HasKey(t => new { t.DepartmentId, t.UserId });

            // properties
            builder.Property(t => t.DepartmentId)
                .IsRequired()
                .HasColumnName("DepartmentId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.Manager)
                .IsRequired()
                .HasColumnName("Manager")
                .HasColumnType("bit");

            builder.Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Department)
                .WithMany(t => t.DepartmentUsers)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DepartmentUser_Department");

            builder.HasOne(t => t.User)
                .WithMany(t => t.DepartmentUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_DepartmentUser_User");

            #endregion
        }

    }
}
