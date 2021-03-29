using Celebrity.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Celebrity.Data
{
    public class TeamsConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasConversion(pointId => (Guid)pointId, id => new TeamId(id));

            builder.OwnsOne(x => x.Name,
              name =>
              {
                  name.Property("value")
                    .IsRequired()
                    .HasMaxLength(Shared.Team.NameMaxLength)
                    .HasColumnName(nameof(TeamName));
              });

            builder.HasMany(e => e.Points)
                .WithOne(e => e.Team)
                .HasForeignKey(e => e.TeamId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
