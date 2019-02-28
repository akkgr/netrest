using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class SessionMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Session>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Session> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Session", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.DateIn)
                .IsRequired()
                .HasColumnName("DateIn")
                .HasColumnType("datetime");

            builder.Property(t => t.ClientId)
                .IsRequired()
                .HasColumnName("ClientId")
                .HasColumnType("int");

            builder.Property(t => t.Ppointment)
                .HasColumnName("Αppointment")
                .HasColumnType("bit");

            builder.Property(t => t.Comment)
                .HasColumnName("Comment")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Subject)
                .HasColumnName("Subject")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Estimation)
                .HasColumnName("Estimation")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Valuation)
                .HasColumnName("Valuation")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Bjectives)
                .HasColumnName("Οbjectives")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Members)
                .HasColumnName("Members")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Client)
                .WithMany(t => t.Sessions)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_Session_Client");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Sessions)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Session_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Sessions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Session_User");

            #endregion
        }

    }
}
