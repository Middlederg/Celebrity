using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Domain
{
    public class DeckConcept : Identity<ConceptId>
    {
        public ConceptName Name { get; private set; }

        public ConceptType Type { get; private set; }

        public IEnumerable<BaseObject> Subcategories { get; private set; }

        public Guid GameId { get; private set; }
        public Game Game { get; private set; }

        public bool IsGuessed { get; private set; }
        public void Guess() => IsGuessed = true;
        public void Reset() => IsGuessed = false;

        public DeckConcept(Concept concept)  
            : this(concept.Id, concept.Name, concept.Type, concept.Subcategories) { }

        public DeckConcept(ConceptId id, ConceptName name, ConceptType type,
            IEnumerable<Subcategory> subcategories) : base(id)
        {
            Name = name;
            Type = type;
            Subcategories = subcategories.Select(x => new BaseObject(x.Id, x.ToString()));
            IsGuessed = false;
        }

        public override string ToString() => Name.ToString();
    }
}
