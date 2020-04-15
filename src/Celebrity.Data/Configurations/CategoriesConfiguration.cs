using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celebrity.Data
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(CategoryName.MaxLength);

            builder.HasMany(e => e.Subcategories)
                .WithOne(e => e.Category)
                .HasForeignKey(e => e.IdCategory)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
