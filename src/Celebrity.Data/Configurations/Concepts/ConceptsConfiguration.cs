using Celebrity.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celebrity.Data
{
    public class ConceptsConfiguration : IEntityTypeConfiguration<Concept>
    {
        public void Configure(EntityTypeBuilder<Concept> builder)
        {
            builder.HasMany(x => x.Subcategories)
                .WithMany(s => s.Concepts);

            builder.OwnsOne(x => x.Name,
              name =>
              {
                  name.Property(p => p.ToString())
                    .IsRequired()
                    .HasMaxLength(Shared.Concept.NameMaxLength)
                    .HasColumnName(nameof(ConceptName));
              });
        }
    }
}
