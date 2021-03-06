using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class CardTypeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.CardType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.CardType> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CardType", "dbo");

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

            builder.Property(t => t.Fields)
                .HasColumnName("Fields")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.PersonType)
                .IsRequired()
                .HasColumnName("PersonType")
                .HasColumnType("int");

            builder.Property(t => t.Monthly)
                .IsRequired()
                .HasColumnName("Monthly")
                .HasColumnType("bit");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            #endregion
        }

    }
}
