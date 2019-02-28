using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class BoardMinuteSubjectMap
        : IEntityTypeConfiguration<Sca.Data.Entities.BoardMinuteSubject>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.BoardMinuteSubject> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("BoardMinuteSubject", "dbo");

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

            builder.Property(t => t.Sn)
                .HasColumnName("SN")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Subject)
                .HasColumnName("Subject")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Decision)
                .HasColumnName("Decision")
                .HasColumnType("nvarchar(max)");

            // relationships
            builder.HasOne(t => t.BoardMinute)
                .WithMany(t => t.BoardMinuteSubjects)
                .HasForeignKey(d => d.BoardminuteId)
                .HasConstraintName("FK_BoardMinuteSubject_BoardMinute");

            #endregion
        }

    }
}
