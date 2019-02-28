using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class PublicationMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Publication>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Publication> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Publication", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SerialNumber)
                .IsRequired()
                .HasColumnName("SerialNumber")
                .HasColumnType("int");

            builder.Property(t => t.RegisterDate)
                .IsRequired()
                .HasColumnName("RegisterDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RankId)
                .IsRequired()
                .HasColumnName("RankId")
                .HasColumnType("int");

            builder.Property(t => t.IsActive)
                .IsRequired()
                .HasColumnName("IsActive")
                .HasColumnType("bit");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.RankDocRank)
                .WithMany(t => t.RankPublications)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("FK_Publication_DocRank");

            #endregion
        }

    }
}
