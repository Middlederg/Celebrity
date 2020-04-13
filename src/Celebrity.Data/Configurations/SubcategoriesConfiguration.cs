using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celebrity.Data
{
    public class SubcategoriesConfiguration : IEntityTypeConfiguration<Subcategories>
    {
        public void Configure(EntityTypeBuilder<Subcategories> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(SubcategoryName.MaxLength);
        }
    }
}
