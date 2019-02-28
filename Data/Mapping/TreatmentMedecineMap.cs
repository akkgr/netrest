using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class TreatmentMedecineMap
        : IEntityTypeConfiguration<Sca.Data.Entities.TreatmentMedecine>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.TreatmentMedecine> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("TreatmentMedecine", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.TreatmentId)
                .IsRequired()
                .HasColumnName("TreatmentId")
                .HasColumnType("int");

            builder.Property(t => t.ItemId)
                .IsRequired()
                .HasColumnName("ItemId")
                .HasColumnType("int");

            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.DoctorId)
                .HasColumnName("DoctorId")
                .HasColumnType("int");

            builder.Property(t => t.MorningMemo)
                .HasColumnName("MorningMemo")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.MorningQuantity)
                .HasColumnName("MorningQuantity")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.OonMemo)
                .HasColumnName("ΝoonMemo")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.OonQuantity)
                .HasColumnName("ΝoonQuantity")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.VeningMemo)
                .HasColumnName("ΕveningMemo")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.VeningQuantity)
                .HasColumnName("ΕveningQuantity")
                .HasColumnType("numeric(18, 2)");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.Doctor)
                .WithMany(t => t.TreatmentMedecines)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("FK_TreatmentMedecine_Doctor");

            builder.HasOne(t => t.Item)
                .WithMany(t => t.TreatmentMedecines)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_TreatmentMedecine_Item");

            builder.HasOne(t => t.Treatment)
                .WithMany(t => t.TreatmentMedecines)
                .HasForeignKey(d => d.TreatmentId)
                .HasConstraintName("FK_TreatmentMedecine_Treatment");

            #endregion
        }

    }
}
