using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celebrity.Data
{
    public class TeamsConfiguration : IEntityTypeConfiguration<TeamsInGame>
    {
        public void Configure(EntityTypeBuilder<TeamsInGame> builder)
        {
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
