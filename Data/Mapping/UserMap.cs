using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class UserMap
        : IEntityTypeConfiguration<Sca.Data.Entities.User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.User> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("User", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.FullName)
                .IsRequired()
                .HasColumnName("FullName")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.UserName)
                .IsRequired()
                .HasColumnName("UserName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Password)
                .IsRequired()
                .HasColumnName("Password")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.IsAdmin)
                .IsRequired()
                .HasColumnName("IsAdmin")
                .HasColumnType("bit");

            builder.Property(t => t.IsActive)
                .IsRequired()
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.BarCode)
                .HasColumnName("BarCode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SecRank)
                .HasColumnName("SecRank")
                .HasColumnType("int");

            builder.Property(t => t.TermsAccepted)
                .IsRequired()
                .HasColumnName("TermsAccepted")
                .HasColumnType("bit");

            builder.Property(t => t.EmployeeId)
                .HasColumnName("EmployeeId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.PasswordHash)
                .HasColumnName("PasswordHash")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.SecurityStamp)
                .HasColumnName("SecurityStamp")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                .HasDefaultValueSql("(newid())");

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.AccessFailedCount)
                .IsRequired()
                .HasColumnName("AccessFailedCount")
                .HasColumnType("int");

            builder.Property(t => t.EmailConfirmed)
                .IsRequired()
                .HasColumnName("EmailConfirmed")
                .HasColumnType("bit");

            builder.Property(t => t.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.PhoneNumberConfirmed)
                .IsRequired()
                .HasColumnName("PhoneNumberConfirmed")
                .HasColumnType("bit");

            builder.Property(t => t.TwoFactorEnabled)
                .IsRequired()
                .HasColumnName("TwoFactorEnabled")
                .HasColumnType("bit");

            builder.Property(t => t.LockoutEndDateUtc)
                .HasColumnName("LockoutEndDateUtc")
                .HasColumnType("datetime");

            builder.Property(t => t.LockoutEnabled)
                .IsRequired()
                .HasColumnName("LockoutEnabled")
                .HasColumnType("bit");

            builder.Property(t => t.ResetPassword)
                .IsRequired()
                .HasColumnName("ResetPassword")
                .HasColumnType("bit");

            builder.Property(t => t.NormalizedUserName)
                .HasColumnName("NormalizedUserName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ConcurrencyStamp)
                .HasColumnName("ConcurrencyStamp")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.LockoutEnd)
                .HasColumnName("LockoutEnd")
                .HasColumnType("datetimeoffset");

            builder.Property(t => t.NormalizedEmail)
                .HasColumnName("NormalizedEmail")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            // relationships
            builder.HasOne(t => t.SecRankDocRank)
                .WithMany(t => t.SecRankUsers)
                .HasForeignKey(d => d.SecRank)
                .HasConstraintName("FK_User_DocRank");

            builder.HasOne(t => t.Employee)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_User_Employee");

            #endregion
        }

    }
}
