using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public class Concept : Identity<ConceptId>
    {
        private readonly ConceptName name;
        
        public Difficulty Difficulty { get; private set; }
        public void SetDifficulty(Difficulty difficulty) => Difficulty = difficulty;

        public ConceptType Type { get; }

        private readonly IEnumerable<SubcategoryObject> subcategories;
        public bool HasSubcategory(SubcategoryId id) => subcategories.Any(x => x.Is(id));

        private bool guessed;
        public bool IsGuessed() => guessed;
        public void Guess() => guessed = true;
        public void Reset() => guessed = false;

        internal static Concept Undefined(ConceptId id) => new Concept(id, new ConceptName($"{id} concept not found"), Difficulty.NotDefined, ConceptType.None);
        public static Concept Create(Guid id, string name, int stars, ConceptType type, params SubcategoryObject[] subcategories)
             => new Concept(new ConceptId(id), new ConceptName(name), Difficulty.GetValue(stars), type, subcategories);

        private Concept(ConceptId conceptId, ConceptName name, Difficulty difficulty, ConceptType type, params SubcategoryObject[] subcategories) 
            : base(conceptId)
        {
            if (Difficulty == null)
            {
                throw new ArgumentNullException(nameof(difficulty));
            }
            this.name = name;
            Difficulty = difficulty;
            Type = type;
            this.subcategories = subcategories;
            guessed = false;
        }

        public override string ToString() => name.ToString();

        public override bool Equals(object obj)
        {
            if (obj is Concept t)
                return t.name.Equals(name);
            return false;
        }

        public override int GetHashCode() => name.GetHashCode();
    }
}
