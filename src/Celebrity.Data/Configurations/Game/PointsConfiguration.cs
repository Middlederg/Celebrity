using Celebrity.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Celebrity.Data
{
    public class PointsConfiguration : IEntityTypeConfiguration<Point>
    {
        public void Configure(EntityTypeBuilder<Point> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasConversion(pointId => (Guid)pointId, id => new PointId(id));

            builder.OwnsOne(x => x.Id,
                 name =>
                 {
                     name.Property("identificator")
                       .IsRequired()
                       .HasColumnName(nameof(ConceptId));
                 });

            builder.OwnsOne(x => x.Name,
              name =>
              {
                  name.Property("value")
                    .IsRequired()
                    .HasMaxLength(Shared.Concept.NameMaxLength)
                    .HasColumnName(nameof(ConceptName));
              });

            builder.OwnsOne(x => x.ConceptId,
               name =>
               {
                   name.Property("identificator")
                     .IsRequired()
                     .HasColumnName(nameof(ConceptId));
               });

          
        }
    }
}
