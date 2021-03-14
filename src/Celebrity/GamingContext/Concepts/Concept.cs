using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.GamingContext
{
    public class Concept : Identity<ConceptId>
    {
        private readonly ConceptName name;

        public ConceptType Type { get; }

        public IEnumerable<BaseObject> Subcategories { get; }

        private bool guessed;
        public bool IsGuessed() => guessed;
        public void Guess() => guessed = true;
        public void Reset() => guessed = false;

        public Concept(ConceptId conceptId, ConceptName name,
            ConceptType type, params BaseObject[] subcategories) 
            : base(conceptId)
        {
            this.name = name;
            Type = type;
            Subcategories = subcategories;
            guessed = false;
        }

        public override string ToString() => name.ToString();
    }
}
