using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Domain
{
    public class DeckConcept : Identity<DeckConceptId>
    {
        public ConceptId ConceptId { get; private set; }

        public ConceptName Name { get; private set; }

        public ConceptType Type { get; private set; }

        public Difficulty Difficulty { get; private set; }

        public IEnumerable<BaseObject> Subcategories { get; private set; }

        public GameId GameId { get; private set; }
        public Game Game { get; private set; }

        public bool IsGuessed { get; private set; }
        public void Guess() => IsGuessed = true;
        public void Reset() => IsGuessed = false;

        public DeckConcept(Concept concept)
            : this(concept.Id,
                  concept.Name,
                  concept.Type,
                  concept.Difficulty,
                  concept.Subcategories.Select(x => new BaseObject(x.Id, x.ToString())),
                  isGuessed:false) { }

        private DeckConcept() { }
        public DeckConcept(ConceptId id, 
            ConceptName name, 
            ConceptType type,
            Difficulty difficulty,
            IEnumerable<BaseObject> subcategories,
            bool isGuessed) : base(id)
        {
            Name = name;
            Type = type;
            Difficulty = difficulty;
            Subcategories = subcategories;
            IsGuessed = isGuessed;
        }

        public override string ToString() => Name.ToString();
    }
}
