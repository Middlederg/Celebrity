using System.Collections.Generic;
using System.Linq;

namespace Celebrity.GamingContext
{
    public class RoundSummary
    {
        public int Round { get; }
        public IEnumerable<string> Concepts { get; }
        public int Points => Concepts.Count();
        public string ConceptsText => string.Join(", ", Concepts);

        public RoundSummary(int round, IEnumerable<string> concepts)
        {
            Round = round;
            Concepts = concepts;
        }

        public override string ToString() => $"Round {Round} - {Points} point{(Points == 1 ? "" : "s")}";
    }
}
