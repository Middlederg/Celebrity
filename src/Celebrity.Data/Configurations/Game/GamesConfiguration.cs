using Celebrity.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celebrity.Data
{
    public class GamesConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            //builder.Property(x => x.Percentage). //precission?
            builder.HasMany(e => e.DeckConcepts)
                .WithOne(e => e.Game)
                .HasForeignKey(e => e.GameId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.Teams)
                .WithOne(e => e.Game)
                .HasForeignKey(e => e.GameId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.OwnsOne(x => x.RoundContext,
              round =>
              {
                  round.Property(p => p.CurrentRound)
                     .HasColumnName(nameof(RoundContext.CurrentRound));

                  round.Ignore(p => p.CurrentRound);
                  round.Ignore(p => p.CurrentRoundNumber);
                  round.Ignore(p => p.TotalRounds);
              });


        }
    }
}
