using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class TraderMap
        : IEntityTypeConfiguration<Sca.Data.Entities.Trader>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.Trader> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Trader", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.BarCode)
                .HasColumnName("BarCode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ContractNo)
                .HasColumnName("ContractNo")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ContractStart)
                .HasColumnName("ContractStart")
                .HasColumnType("datetime");

            builder.Property(t => t.ContractEnd)
                .HasColumnName("ContractEnd")
                .HasColumnType("datetime");

            builder.Property(t => t.Afm)
                .HasColumnName("AFM")
                .HasColumnType("nvarchar(9)")
                .HasMaxLength(9);

            builder.Property(t => t.DOYId)
                .HasColumnName("DOYId")
                .HasColumnType("int");

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Amount)
                .HasColumnName("Amount")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Recieve)
                .HasColumnName("Recieve")
                .HasColumnType("bit");

            builder.Property(t => t.Provide)
                .HasColumnName("Provide")
                .HasColumnType("bit");

            builder.Property(t => t.Photo)
                .HasColumnName("Photo")
                .HasColumnType("varbinary(max)");

            builder.Property(t => t.RankId)
                .HasColumnName("RankId")
                .HasColumnType("int");

            builder.Property(t => t.OrgTreeNodeId)
                .HasColumnName("OrgTreeNodeId")
                .HasColumnType("int");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.RowVersion)
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            builder.HasOne(t => t.RankDocRank)
                .WithMany(t => t.RankTraders)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("FK_Trader_DocRank");

            builder.HasOne(t => t.Doy)
                .WithMany(t => t.Traders)
                .HasForeignKey(d => d.DOYId)
                .HasConstraintName("FK_Trader_DOY");

            builder.HasOne(t => t.OrgTreeNode)
                .WithMany(t => t.Traders)
                .HasForeignKey(d => d.OrgTreeNodeId)
                .HasConstraintName("FK_Trader_OrgTreeNode");

            builder.HasOne(t => t.User)
                .WithMany(t => t.Traders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Trader_User");

            #endregion
        }

    }
}
