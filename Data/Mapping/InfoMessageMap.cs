using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class InfoMessageMap
        : IEntityTypeConfiguration<Sca.Data.Entities.InfoMessage>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.InfoMessage> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("InfoMessage", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Caption)
                .IsRequired()
                .HasColumnName("Caption")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Message)
                .IsRequired()
                .HasColumnName("Message")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Commencement)
                .IsRequired()
                .HasColumnName("Commencement")
                .HasColumnType("datetime");

            builder.Property(t => t.Expiration)
                .IsRequired()
                .HasColumnName("Expiration")
                .HasColumnType("datetime");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.LinkTable)
                .HasColumnName("LinkTable")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.LinkId)
                .HasColumnName("LinkId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.User)
                .WithMany(t => t.InfoMessages)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_InfoMessage_User");

            #endregion
        }

    }
}
