using Celebrity.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celebrity.Data
{
    public class SubcategoriesConfiguration : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.OwnsOne(x => x.Name,
              name =>
              {
                  name.Property(p => p.ToString())
                    .IsRequired()
                    .HasMaxLength(Shared.Subcategory.NameMaxLength)
                    .HasColumnName(nameof(SubcategoryName));
              });

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(Shared.Subcategory.NameMaxLength);

            builder.HasMany(e => e.Concepts)
                .WithMany(e => e.Subcategories);
        }
    }
}
