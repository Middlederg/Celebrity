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
        public void AddPoint(DeckConcept tarjeta, int ronda) => points.Add(new Point(tarjeta, ronda));
        public IEnumerable<(ConceptId id, int round)> GetPointsInfo() => points.Select(x => x.GetInfo);

        public int Fails { get; private set; }
        public void AddFailure() => Fails++;

        public GameId GameId { get; private set; }
        public Game Game { get; private set; }

        public Team(TeamId id, Color color, string name = null) : base(id)
        {
            this.Name = new TeamName(string.IsNullOrWhiteSpace(name) ? color.Description() : name);
            Color = color;
            points = new List<Point>();
            Fails = 0;
        }

        public IEnumerable<string> GuessedConcepts(Round round)
        {
            return points
                .Where(x => x.Round == round.Number)
                .Select(x => x.Concept.ToString());
        }

        public IEnumerable<string> TotalGuessedConcepts()
        {
            return points.Select(x => x.Concept.ToString());
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
