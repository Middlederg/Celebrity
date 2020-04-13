using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celebrity.Data
{
    public class ConceptsConfiguration : IEntityTypeConfiguration<Concepts>
    {
        public void Configure(EntityTypeBuilder<Concepts> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(ConceptName.MaxLength);
        }
    }
}
