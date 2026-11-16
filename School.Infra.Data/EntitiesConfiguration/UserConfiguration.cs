using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Data.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.PasswordHash)
                .IsRequired();

            builder.Property(u => u.PasswordSalt)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
