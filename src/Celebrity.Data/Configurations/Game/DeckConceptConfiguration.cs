using Celebrity.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Celebrity.Data
{
    public class DeckConceptConfiguration : IEntityTypeConfiguration<DeckConcept>
    {
        public void Configure(EntityTypeBuilder<DeckConcept> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasConversion(pointId => (Guid)pointId, id => new DeckConceptId(id));

            builder.OwnsOne(x => x.ConceptId,
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

            builder.Property(e => e.Subcategories).HasConversion(
                v => JsonSerializer.Serialize(v, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                }),
                v => JsonSerializer.Deserialize<IEnumerable<BaseObject>>(v, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                }));

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
