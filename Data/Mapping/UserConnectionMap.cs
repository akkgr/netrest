using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Mapping
{
    public partial class UserConnectionMap
        : IEntityTypeConfiguration<Sca.Data.Entities.UserConnection>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sca.Data.Entities.UserConnection> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("UserConnection", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserName)
                .HasColumnName("UserName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FullName)
                .HasColumnName("FullName")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.ConnectionId)
                .HasColumnName("ConnectionId")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SignIn)
                .HasColumnName("SignIn")
                .HasColumnType("datetime");

            builder.Property(t => t.SignOut)
                .HasColumnName("SignOut")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

    }
}
