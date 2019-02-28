using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class UserClaimMap
        : IEntityTypeConfiguration<Sca.Data.Entities.UserClaim>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.UserClaim> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("UserClaim", "dbo");

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

            builder.Property(t => t.ClaimType)
                .HasColumnName("ClaimType")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ClaimValue)
                .HasColumnName("ClaimValue")
                .HasColumnType("nvarchar(max)");

            // relationships
            builder.HasOne(t => t.User)
                .WithMany(t => t.UserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserClaim_User");

            #endregion
        }

    }
}
