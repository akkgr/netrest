using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class UserDivisionMap
        : IEntityTypeConfiguration<Sca.Data.Entities.UserDivision>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.UserDivision> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("UserDivision", "dbo");

            // key
            builder.HasKey(t => new { t.UserId, t.DivisionId });

            // properties
            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.DivisionId)
                .IsRequired()
                .HasColumnName("DivisionId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Division)
                .WithMany(t => t.UserDivisions)
                .HasForeignKey(d => d.DivisionId)
                .HasConstraintName("FK_UserDivision_Division");

            builder.HasOne(t => t.User)
                .WithMany(t => t.UserDivisions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserDivision_User");

            #endregion
        }

    }
}
