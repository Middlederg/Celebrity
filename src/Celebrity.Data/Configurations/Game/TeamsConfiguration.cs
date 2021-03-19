using Celebrity.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celebrity.Data
{
    public class TeamsConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.OwnsOne(x => x.Name,
              name =>
              {
                  name.Property(p => p.ToString())
                    .IsRequired()
                    .HasMaxLength(Shared.Team.NameMaxLength)
                    .HasColumnName(nameof(SubcategoryName));
              });

            builder.Property(x => x.TeamName)
                .IsRequired()
                .HasMaxLength(TeamName.MaxLength);

            builder.HasMany(e => e.Points)
                .WithOne(e => e.Team)
                .HasForeignKey(e => e.TeamId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
