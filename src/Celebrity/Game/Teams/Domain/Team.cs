using System.Collections.Generic;
using Celebrity.Shared;
using System.Linq;

namespace Celebrity.Domain
{
    public class Team : Identity<TeamId>
    {
        public TeamName Name { get; private set; }

        public Color Color { get; private set; }

        public ICollection<Point> Points { get; private set; }

        private readonly List<Point> points;
        public void AddPoint(DeckConcept concept, int round) => points.Add(new Point(new PointId(), concept, round));

        public int Fails { get; private set; }
        public void AddFailure() => Fails++;

        public GameId GameId { get; private set; }
        public Game Game { get; private set; }

        private Team() { }
        public Team(TeamId id, Color color, GameId gameId, string name = null) : base(id)
        {
            Name = new TeamName(string.IsNullOrWhiteSpace(name) ? color.Description() : name);
            GameId = gameId;
            Color = color;
            points = new List<Point>();
            Fails = 0;
        }

        public IEnumerable<string> GuessedConcepts(Round round)
        {
            return points
                .Where(x => x.Round == round.Number)
                .Select(x => x.Name.ToString());
        }

        public IEnumerable<string> TotalGuessedConcepts()
        {
            return points.Select(x => x.Name.ToString());
        }

        public IEnumerable<RoundSummary> Summary(int totalRounds)
        {
            foreach (var round in new RoundFactory(totalRounds).Create())
            {
                var guessedConcepts = GuessedConcepts(round);
                yield return new RoundSummary(round.Number, guessedConcepts);
            }
        }

        public override string ToString() => Name.ToString();
    }

}
