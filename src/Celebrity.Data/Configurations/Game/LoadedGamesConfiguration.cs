using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celebrity.Data
{
    public class LoadedGamesConfiguration : IEntityTypeConfiguration<LoadedGames>
    {
        public void Configure(EntityTypeBuilder<LoadedGames> builder)
        {
            builder.Property(x => x.UserAgent)
                .IsRequired()
                .HasMaxLength(UserAgent.MaxLength);

            builder.Property(x => x.IpAddress)
                .IsRequired()
                .HasMaxLength(IpAddress.MaxLength);
        }
    }
}
