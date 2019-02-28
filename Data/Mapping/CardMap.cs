using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class CardMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Card>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Card> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Card", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CardTypeId)
                .IsRequired()
                .HasColumnName("CardTypeId")
                .HasColumnType("int");

            builder.Property(t => t.DateIn)
                .HasColumnName("DateIn")
                .HasColumnType("datetime");

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.CardValues)
                .HasColumnName("CardValues")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.VisibleToEmployee)
                .IsRequired()
                .HasColumnName("VisibleToEmployee")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.RankId)
                .IsRequired()
                .HasColumnName("RankId")
                .HasColumnType("int")
                .HasDefaultValueSql("((4))");

            builder.Property(t => t.Photo)
                .HasColumnName("Photo")
                .HasColumnType("varbinary(max)");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.CardType)
                .WithMany(t => t.Cards)
                .HasForeignKey(d => d.CardTypeId)
                .HasConstraintName("FK_Card_CardType");

            builder.HasOne(t => t.RankDocRank)
                .WithMany(t => t.RankCards)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("FK_Card_DocRank");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Cards)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Card_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Cards)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Card_User");

            #endregion
        }

    }
}
