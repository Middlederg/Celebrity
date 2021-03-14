using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.GamingContext
{
    public class Deck
    {
        public const int MinConcepts = 10;
        public const int MaxConcepts = 100;
        public const int DefaultConcepts = 40;

        private readonly List<Concept> concepts;
        public IEnumerable<BaseOption<ConceptId>> GetAllconcepts() => concepts
            .Select(x => new BaseOption<ConceptId>(x.Id, x.IsGuessed()));

        internal Deck(List<Concept> concepts)
        {
            this.concepts = concepts;

            Ensure.NotNull(concepts);
            Ensure.That<ArgumentOutOfRangeException>(concepts.Count >= MinConcepts && concepts.Count <= MaxConcepts,
             $"Can not create a deck with {concepts.Count} concepts");
        }

        public void Guess() => VisibleConcept.Guess();
        public void Reset()
        {
            foreach (var concept in concepts)
            {
                concept.Reset();
            }
        }

        public void NextConcept()
        {
            var concept = VisibleConcept;
            concepts.Remove(concept);
            concepts.Add(concept);
        }

        public bool IsFinished => concepts.All(x => x.IsGuessed());
        public int GuessedConceptCount => concepts.Count(x => x.IsGuessed());
        public int RemainingConceptCount => concepts.Count(x => !x.IsGuessed());
        public int ConceptCount => concepts.Count;
        public Concept VisibleConcept => concepts.First(x => !x.IsGuessed());

        public Concept SearchConcept(ConceptId id)
        {
            var concept = concepts.FirstOrDefault(x => x.Id == id);
            if (concept == null)
            {
                return Concept.Undefined(id);
            }
            return concept;
        }
    }
}
