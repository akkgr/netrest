using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class CardClientMap
        : IEntityTypeConfiguration<Sca.Data.Entities.CardClient>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.CardClient> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CardClient", "dbo");

            // key
            builder.HasKey(t => new { t.CardId, t.ClientId });

            // properties
            builder.Property(t => t.CardId)
                .IsRequired()
                .HasColumnName("CardId")
                .HasColumnType("int");

            builder.Property(t => t.ClientId)
                .IsRequired()
                .HasColumnName("ClientId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Card)
                .WithMany(t => t.CardClients)
                .HasForeignKey(d => d.CardId)
                .HasConstraintName("FK_CardClient_Card");

            builder.HasOne(t => t.Client)
                .WithMany(t => t.CardClients)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_CardClient_Client");

            #endregion
        }

    }
}
