using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class FileDataMap
        : IEntityTypeConfiguration<Sca.Data.Entities.FileData>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.FileData> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("FileData", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UnqId)
                .IsRequired()
                .HasColumnName("unqId")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.FileName)
                .IsRequired()
                .HasColumnName("FileName")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.Hash)
                .HasColumnName("Hash")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Compressed)
                .IsRequired()
                .HasColumnName("Compressed")
                .HasColumnType("bit");

            builder.Property(t => t.Uploaded)
                .HasColumnName("Uploaded")
                .HasColumnType("bit");

            // relationships
            #endregion
        }

    }
}
