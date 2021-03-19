using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Domain
{
    public class Deck
    {
        public const int MinConcepts = 10;
        public const int MaxConcepts = 100;
        public const int DefaultConcepts = 40;

        private readonly IEnumerable<DeckConcept> concepts;

        internal Deck(IEnumerable<DeckConcept> concepts)
        {
            this.concepts = concepts;

            Ensure.NotNull(concepts);
            Ensure.That<ArgumentOutOfRangeException>(concepts.Count() >= MinConcepts && concepts.Count() <= MaxConcepts,
             $"Can not create a deck with {concepts.Count()} concepts");
        }

        public void Guess() => VisibleConcept.Guess();

        public bool IsFinished => concepts.All(x => x.IsGuessed);
        public int GuessedCount => concepts.Count(x => x.IsGuessed);
        public int PendingCount => concepts.Count(x => !x.IsGuessed);
        public int ConceptCount => concepts.Count();
        public DeckConcept VisibleConcept => concepts.First(x => !x.IsGuessed);
    }
}
