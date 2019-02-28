using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class AppointmentTypeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.AppointmentType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.AppointmentType> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AppointmentType", "dbo");

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
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Color)
                .HasColumnName("Color")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Cost)
                .IsRequired()
                .HasColumnName("Cost")
                .HasColumnType("decimal(18, 2)");

            // relationships
            #endregion
        }

    }
}
