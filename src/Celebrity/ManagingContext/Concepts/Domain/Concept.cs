using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.ManagingContext
{
    public class Concept : Identity<ConceptId>
    {
        private readonly ConceptName name;

        public Difficulty Difficulty { get; private set; }
        public void SetDifficulty(Difficulty difficulty) => Difficulty = difficulty;

        public ConceptType Type { get; }

        public Concept(ConceptId id, ConceptName name, Difficulty difficulty, ConceptType type, 
            ICollection<Subcategory> subcategories) : base(id)
        {
            this.name = name;
            Difficulty = difficulty;
            Type = type;
            Subcategories = subcategories;
        }

        public ICollection<Subcategory> Subcategories { get; private set; }

        public override string ToString() => name.ToString();
    }
}
