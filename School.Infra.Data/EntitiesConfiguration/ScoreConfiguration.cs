using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Data.EntitiesConfiguration
{
    public class ScoreConfiguration : IEntityTypeConfiguration<Score>
    {
        public void Configure(EntityTypeBuilder<Score> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.RegistrationId).IsRequired();
            builder.Property(s => s.ScoreValue).IsRequired();

            builder.HasOne(x => x.Registration)
                .WithMany(x => x.Scores)
                .HasForeignKey(x => x.RegistrationId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
