using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class ClientServiceMap
        : IEntityTypeConfiguration<Sca.Data.Entities.ClientService>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.ClientService> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ClientService", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ClientId)
                .IsRequired()
                .HasColumnName("ClientId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .IsRequired()
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.Balance)
                .IsRequired()
                .HasColumnName("Balance")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Active)
                .HasColumnName("Active")
                .HasColumnType("int");

            builder.Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.LastUpdated)
                .IsRequired()
                .HasColumnName("LastUpdated")
                .HasColumnType("datetime");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Client)
                .WithMany(t => t.ClientServices)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_ClientService_Client");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.ClientServices)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_ClientService_OrgTreeNode");

            #endregion
        }

    }
}
