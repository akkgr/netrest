using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class WorkGroupTypeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.WorkGroupType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.WorkGroupType> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("WorkGroupType", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            // relationships
            #endregion
        }

    }
}