using Celebrity.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Celebrity.Data
{
    public class ConceptsConfiguration : IEntityTypeConfiguration<Concept>
    {
        public void Configure(EntityTypeBuilder<Concept> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasConversion(pointId => (Guid)pointId, id => new ConceptId(id));

            builder.HasMany(x => x.Subcategories)
                .WithMany(s => s.Concepts);

            builder.OwnsOne(x => x.Name,
              name =>
              {
                  name.Property("value")
                    .IsRequired()
                    .HasMaxLength(Shared.Concept.NameMaxLength)
                    .HasColumnName(nameof(ConceptName));
              });
        }
    }
}
