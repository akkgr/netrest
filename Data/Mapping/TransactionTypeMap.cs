using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class TransactionTypeMap
        : IEntityTypeConfiguration<Sca.Data.Entities.TransactionType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.TransactionType> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("TransactionType", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Act)
                .IsRequired()
                .HasColumnName("Act")
                .HasColumnType("int");

            builder.Property(t => t.IsCash)
                .IsRequired()
                .HasColumnName("IsCash")
                .HasColumnType("bit");

            builder.Property(t => t.CustomerAct)
                .IsRequired()
                .HasColumnName("CustomerAct")
                .HasColumnType("int");

            builder.Property(t => t.ProviderAct)
                .IsRequired()
                .HasColumnName("ProviderAct")
                .HasColumnType("int");

            // relationships
            #endregion
        }

    }
}
