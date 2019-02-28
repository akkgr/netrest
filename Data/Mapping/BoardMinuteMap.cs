using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class BoardMinuteMap
        : IEntityTypeConfiguration<Sca.Data.Entities.BoardMinute>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.BoardMinute> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("BoardMinute", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.MeetingDate)
                .IsRequired()
                .HasColumnName("MeetingDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Minutes)
                .HasColumnName("Minutes")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.Emailed)
                .HasColumnName("Emailed")
                .HasColumnType("datetime");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.BoardMinutes)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_BoardMinute_OrgTreeNode");

            #endregion
        }

    }
}
