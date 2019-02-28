using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class DocUserMap
        : IEntityTypeConfiguration<Sca.Data.Entities.DocUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.DocUser> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DocUser", "dbo");

            // key
            builder.HasKey(t => new { t.DocId, t.UserId });

            // properties
            builder.Property(t => t.DocId)
                .IsRequired()
                .HasColumnName("DocId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.ActionInfo)
                .IsRequired()
                .HasColumnName("ActionInfo")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.DocDocument)
                .WithMany(t => t.DocDocUsers)
                .HasForeignKey(d => d.DocId)
                .HasConstraintName("FK_DocUser_Document");

            builder.HasOne(t => t.User)
                .WithMany(t => t.DocUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_DocUser_User");

            #endregion
        }

    }
}
