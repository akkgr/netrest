using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class FileLinkMap
        : IEntityTypeConfiguration<Sca.Data.Entities.FileLink>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.FileLink> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("FileLink", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.FileDataId)
                .IsRequired()
                .HasColumnName("FileDataId")
                .HasColumnType("int");

            builder.Property(t => t.EntityType)
                .IsRequired()
                .HasColumnName("EntityType")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.EntityId)
                .IsRequired()
                .HasColumnName("EntityId")
                .HasColumnType("int");

            builder.Property(t => t.FileName)
                .IsRequired()
                .HasColumnName("FileName")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.TypeId)
                .HasColumnName("TypeId")
                .HasColumnType("int");

            builder.Property(t => t.IsPrivate)
                .HasColumnName("isPrivate")
                .HasColumnType("bit");

            builder.Property(t => t.PublicationDate)
                .HasColumnName("PublicationDate")
                .HasColumnType("datetime");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.TypeAttachmentType)
                .WithMany(t => t.TypeFileLinks)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_FileLink_AttachmentType");

            builder.HasOne(t => t.FileData)
                .WithMany(t => t.FileLinks)
                .HasForeignKey(d => d.FileDataId)
                .HasConstraintName("FK_FileLink_FileData");

            #endregion
        }

    }
}
