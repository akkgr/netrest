using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class DocumentMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Document>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Document> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Document", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.RegistrationDate)
                .IsRequired()
                .HasColumnName("RegistrationDate")
                .HasColumnType("datetime");

            builder.Property(t => t.FromTo)
                .HasColumnName("FromTo")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Subject)
                .HasColumnName("Subject")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.InOut)
                .IsRequired()
                .HasColumnName("InOut")
                .HasColumnType("int");

            builder.Property(t => t.InDocRegistration)
                .HasColumnName("InDocRegistration")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.InDocDate)
                .HasColumnName("InDocDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Receipt)
                .HasColumnName("Receipt")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.TempRegistration)
                .HasColumnName("TempRegistration")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.RankId)
                .HasColumnName("RankId")
                .HasColumnType("int");

            builder.Property(t => t.Registration)
                .HasColumnName("Registration")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.UserId)
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.RegNum)
                .IsRequired()
                .HasColumnName("RegNum")
                .HasColumnType("int");

            builder.Property(t => t.OutDocRegistration)
                .HasColumnName("OutDocRegistration")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Deleted)
                .IsRequired()
                .HasColumnName("Deleted")
                .HasColumnType("bit");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.RankDocRank)
                .WithMany(t => t.RankDocuments)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("FK_Document_DocRank");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Documents)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Document_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Documents)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Document_User");

            #endregion
        }

    }
}
