using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Celebrity
{
    public class Team
    {
        private readonly TeamName name;
        public Color Color { get; }
        
        private readonly List<Point> points;
        public void AddPoint(Concept tarjeta, int ronda) => points.Add(new Point(tarjeta, ronda));

        public int Fails { get; private set; }
        public void AddFailure() => Fails++;

        public Team(Color color, string name = null)
        {
            this.name = new TeamName(string.IsNullOrWhiteSpace(name) ? color.Description() : name);
            Color = color;
            points = new List<Point>();
            Fails = 0;
        }

        //public int Points(Round round) => GuessedConcepts(x => x.Round == round.Number);
        //public int TotalPoints() => points.Count();

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

        public override bool Equals(object obj)
        {
            if (obj is Team otherTeam)
            {
                return name.Equals(otherTeam);
            }
            return false;
        }
        public override int GetHashCode() => name.GetHashCode();

        public override string ToString() => name.ToString();
    }
}
