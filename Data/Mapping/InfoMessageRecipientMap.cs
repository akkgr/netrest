using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class InfoMessageRecipientMap
        : IEntityTypeConfiguration<Sca.Data.Entities.InfoMessageRecipient>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.InfoMessageRecipient> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("InfoMessageRecipient", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.InfoMessageId)
                .IsRequired()
                .HasColumnName("InfoMessageId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.Received)
                .IsRequired()
                .HasColumnName("Received")
                .HasColumnType("bit");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.InfoMessage)
                .WithMany(t => t.InfoMessageRecipients)
                .HasForeignKey(d => d.InfoMessageId)
                .HasConstraintName("FK_InfoMessageRecipient_InfoMessage");

            builder.HasOne(t => t.User)
                .WithMany(t => t.InfoMessageRecipients)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_InfoMessageRecipient_User");

            #endregion
        }

    }
}
