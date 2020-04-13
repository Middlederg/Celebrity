using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celebrity.Data
{
    public class SubcategoriesInConceptsConfiguration : IEntityTypeConfiguration<SubcategoriesInConcepts>
    {
        public void Configure(EntityTypeBuilder<SubcategoriesInConcepts> builder)
        {
            builder.HasOne(x => x.Subcategories)
                .WithMany(s => s.SubcategoriesInconcepts)
                .HasForeignKey(sc => sc.SubcategoryId);

            builder.HasOne(x => x.Concepts)
                .WithMany(s => s.SubcategoriesInconcepts)
                .HasForeignKey(sc => sc.ConceptId);
        }
    }
}
