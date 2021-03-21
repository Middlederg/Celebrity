using Celebrity.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Celebrity.Data
{
    public class SubcategoriesConfiguration : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasConversion(pointId => (Guid)pointId, id => new SubcategoryId(id));

            builder.OwnsOne(x => x.Name,
              name =>
              {
                  name.Property("value")
                    .IsRequired()
                    .HasMaxLength(Shared.Subcategory.NameMaxLength)
                    .HasColumnName(nameof(SubcategoryName));
              });

            builder.HasMany(e => e.Concepts)
                .WithMany(e => e.Subcategories);
        }
    }
}
