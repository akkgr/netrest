using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ReferralMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Referral>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Referral> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Referral", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ClientId)
                .HasColumnName("ClientId")
                .HasColumnType("int");

            builder.Property(t => t.IntakeId)
                .HasColumnName("IntakeId")
                .HasColumnType("int");

            builder.Property(t => t.NewIntakeId)
                .HasColumnName("NewIntakeId")
                .HasColumnType("int");

            builder.Property(t => t.FromOrgId)
                .IsRequired()
                .HasColumnName("FromOrgId")
                .HasColumnType("int");

            builder.Property(t => t.ToOrgId)
                .HasColumnName("ToOrgId")
                .HasColumnType("int");

            builder.Property(t => t.FromUserId)
                .IsRequired()
                .HasColumnName("FromUserId")
                .HasColumnType("int");

            builder.Property(t => t.ToUserId)
                .HasColumnName("ToUserId")
                .HasColumnType("int");

            builder.Property(t => t.DateSend)
                .IsRequired()
                .HasColumnName("DateSend")
                .HasColumnType("datetime");

            builder.Property(t => t.DateReceived)
                .HasColumnName("DateReceived")
                .HasColumnType("datetime");

            builder.Property(t => t.ReferralLevelId)
                .HasColumnName("ReferralLevelId")
                .HasColumnType("int");

            builder.Property(t => t.Files)
                .HasColumnName("Files")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Request)
                .HasColumnName("Request")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Cancelled)
                .IsRequired()
                .HasColumnName("Cancelled")
                .HasColumnType("bit");

            builder.Property(t => t.CancelReason)
                .HasColumnName("CancelReason")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Client)
                .WithMany(t => t.Referrals)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_Referral_Client");

            builder.HasOne(t => t.Intake)
                .WithMany(t => t.Referrals)
                .HasForeignKey(d => d.IntakeId)
                .HasConstraintName("FK_Referral_Intake");

            builder.HasOne(t => t.NewIntake)
                .WithMany(t => t.NewReferrals)
                .HasForeignKey(d => d.NewIntakeId)
                .HasConstraintName("FK_Referral_Intake1");

            builder.HasOne(t => t.FromOrgOrgTreeNode)
                .WithMany(t => t.FromOrgReferrals)
                .HasForeignKey(d => d.FromOrgId)
                .HasConstraintName("FK_Referral_OrgTreeNode");

            builder.HasOne(t => t.ToOrgOrgTreeNode)
                .WithMany(t => t.ToOrgReferrals)
                .HasForeignKey(d => d.ToOrgId)
                .HasConstraintName("FK_Referral_OrgTreeNode1");

            builder.HasOne(t => t.ReferralLevel)
                .WithMany(t => t.Referrals)
                .HasForeignKey(d => d.ReferralLevelId)
                .HasConstraintName("FK_Referral_ReferralLevel");

            builder.HasOne(t => t.FromUser)
                .WithMany(t => t.FromReferrals)
                .HasForeignKey(d => d.FromUserId)
                .HasConstraintName("FK_Referral_User");

            builder.HasOne(t => t.ToUser)
                .WithMany(t => t.ToReferrals)
                .HasForeignKey(d => d.ToUserId)
                .HasConstraintName("FK_Referral_User1");

            #endregion
        }

    }
}
