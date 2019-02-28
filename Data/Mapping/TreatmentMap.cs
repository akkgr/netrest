using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class TreatmentMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Treatment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Treatment> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Treatment", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Sn)
                .IsRequired()
                .HasColumnName("Sn")
                .HasColumnType("int");

            builder.Property(t => t.IntakeId)
                .HasColumnName("IntakeId")
                .HasColumnType("int");

            builder.Property(t => t.ClientId)
                .HasColumnName("ClientId")
                .HasColumnType("int");

            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Njectable)
                .HasColumnName("Ιnjectable")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.NjectableNote)
                .HasColumnName("ΙnjectableNote")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Nxiety)
                .HasColumnName("Αnxiety")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.NxietyNote)
                .HasColumnName("ΑnxietyNote")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.NtenseΑnxiety)
                .HasColumnName("ΙntenseΑnxiety")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.NtenseΑnxietyNote)
                .HasColumnName("ΙntenseΑnxietyNote")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

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
                .WithMany(t => t.Treatments)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_Treatment_Client");

            builder.HasOne(t => t.Intake)
                .WithMany(t => t.Treatments)
                .HasForeignKey(d => d.IntakeId)
                .HasConstraintName("FK_Treatment_Intake");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Treatments)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Treatment_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Treatments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Treatment_User");

            #endregion
        }

    }
}
