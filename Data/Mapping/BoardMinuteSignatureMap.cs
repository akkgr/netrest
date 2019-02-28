using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class BoardMinuteSignatureMap
        : IEntityTypeConfiguration<Sca.Data.Entities.BoardMinuteSignature>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.BoardMinuteSignature> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("BoardMinuteSignature", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.BoardminuteId)
                .IsRequired()
                .HasColumnName("BoardminuteId")
                .HasColumnType("int");

            builder.Property(t => t.BoardMemberId)
                .IsRequired()
                .HasColumnName("BoardMemberId")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.LastName)
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Signature)
                .HasColumnName("Signature")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Signed)
                .IsRequired()
                .HasColumnName("Signed")
                .HasColumnType("bit");

            // relationships
            builder.HasOne(t => t.BoardMember)
                .WithMany(t => t.BoardMinuteSignatures)
                .HasForeignKey(d => d.BoardMemberId)
                .HasConstraintName("FK_BoardMinuteSignature_BoardMember");

            builder.HasOne(t => t.BoardMinute)
                .WithMany(t => t.BoardMinuteSignatures)
                .HasForeignKey(d => d.BoardminuteId)
                .HasConstraintName("FK_BoardMinuteSignature_BoardMinute");

            #endregion
        }

    }
}
