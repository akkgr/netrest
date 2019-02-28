using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class PhoneBookEntryMap
        : IEntityTypeConfiguration<Sca.Data.Entities.PhoneBookEntry>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.PhoneBookEntry> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PhoneBookEntry", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.LastName)
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Company)
                .HasColumnName("Company")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Address)
                .HasColumnName("Address")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Phone1)
                .HasColumnName("Phone1")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Phone2)
                .HasColumnName("Phone2")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Phone3)
                .HasColumnName("Phone3")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Phone4)
                .HasColumnName("Phone4")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Fax)
                .HasColumnName("Fax")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.DocRankId)
                .IsRequired()
                .HasColumnName("DocRankId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.DocRank)
                .WithMany(t => t.PhoneBookEntries)
                .HasForeignKey(d => d.DocRankId)
                .HasConstraintName("FK_PhoneBookEntry_DocRank");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.PhoneBookEntries)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_PhoneBookEntry_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.PhoneBookEntries)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_PhoneBookEntry_User");

            #endregion
        }

    }
}
