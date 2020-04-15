using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celebrity.Data
{
    public class GamesConfiguration : IEntityTypeConfiguration<Games>
    {
        public void Configure(EntityTypeBuilder<Games> builder)
        {
            //builder.Property(x => x.Percentage). //precission?
            builder.HasMany(e => e.Concepts)
                .WithOne(e => e.Game)
                .HasForeignKey(e => e.GameId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.Teams)
                .WithOne(e => e.Game)
                .HasForeignKey(e => e.GameId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.LoadedGames)
                .WithOne(e => e.Game)
                .HasForeignKey(e => e.GameId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
