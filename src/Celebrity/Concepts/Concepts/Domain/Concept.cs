using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Domain
{
    public class Concept : Identity<ConceptId>
    {
        public ConceptName Name { get; private set; }
        public void UpdateName(string name) => Name = new ConceptName(name);

        public Difficulty Difficulty { get; private set; }
        public void UpdateDifficulty(Difficulty value) => Difficulty = value;

        public ConceptType Type { get; private set; }
        public void UpdateType(ConceptType value) => Type = value;

        public Concept(ConceptId id, ConceptName name, Difficulty difficulty, ConceptType type, 
            ICollection<Subcategory> subcategories) : base(id)
        {
            Name = name;
            Difficulty = difficulty;
            Type = type;
            Subcategories = subcategories;
        }

        public ICollection<Subcategory> Subcategories { get; private set; }

        public override string ToString() => Name.ToString();
    }
}
