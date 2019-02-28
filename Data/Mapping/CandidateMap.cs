using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class CandidateMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Candidate>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Candidate> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Candidate", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Adt)
                .HasColumnName("ADT")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Afm)
                .HasColumnName("AFM")
                .HasColumnType("nvarchar(9)")
                .HasMaxLength(9);

            builder.Property(t => t.Address)
                .HasColumnName("Address")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StreetNumber)
                .HasColumnName("StreetNumber")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.City)
                .HasColumnName("City")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.PostalCode)
                .HasColumnName("PostalCode")
                .HasColumnType("nvarchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.Phone)
                .HasColumnName("Phone")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.BirthDate)
                .HasColumnName("BirthDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.WorkPositionId)
                .HasColumnName("WorkPositionId")
                .HasColumnType("int");

            builder.Property(t => t.InterestId)
                .HasColumnName("InterestId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.RankId)
                .HasColumnName("RankId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.Inserted)
                .HasColumnName("Inserted")
                .HasColumnType("datetime");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.InterestCandidateInterest)
                .WithMany(t => t.InterestCandidates)
                .HasForeignKey(d => d.InterestId)
                .HasConstraintName("FK_Candidate_CandidateΙnterest");

            builder.HasOne(t => t.RankDocRank)
                .WithMany(t => t.RankCandidates)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("FK_Candidate_DocRank");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Candidates)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Candidate_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Candidates)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Candidate_User");

            builder.HasOne(t => t.WorkPosition)
                .WithMany(t => t.Candidates)
                .HasForeignKey(d => d.WorkPositionId)
                .HasConstraintName("FK_Candidate_WorkPosition");

            #endregion
        }

    }
}
