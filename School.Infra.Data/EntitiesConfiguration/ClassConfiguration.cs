using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Data.EntitiesConfiguration
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(c => c.CourseId).IsRequired();

            builder.HasOne(x => x.Course)
                .WithMany(x => x.Classes)
                .HasForeignKey(x => x.CourseId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
