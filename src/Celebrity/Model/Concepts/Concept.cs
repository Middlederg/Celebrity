﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public class Concept : Identity<ConceptId>
    {
        private readonly ConceptName name;
        
        public Difficulty Difficulty { get; private set; }
        public void SetDifficulty(Difficulty difficulty) => Difficulty = difficulty;

        public bool IsCustomized { get; }

        private readonly IEnumerable<SubcategoryObject> subcategories;
        public bool HasSubcategory(SubcategoryId id) => subcategories.Any(x => x.Is(id));

        private bool guessed;
        public bool IsGuessed() => guessed;
        public void Guess() => guessed = true;
        public void Reset() => guessed = false;

        internal static Concept Create(string name, int stars, params SubcategoryObject[] subcategories)
             => new Concept(new ConceptId(), new ConceptName(name), Difficulty.GetValue(stars), isCustomized: true, subcategories);

        public static Concept CreateCustom(string name, int stars, params SubcategoryObject[] subcategories)
             => new Concept(new ConceptId(), new ConceptName(name), Difficulty.GetValue(stars), isCustomized: true, subcategories);

        public static Concept FromDataBase(Guid id, string name, int stars, bool isCustomized, params SubcategoryObject[] subcategories) 
            => new Concept(new ConceptId(id), new ConceptName(name), Difficulty.GetValue(stars), isCustomized, subcategories);

        private Concept(ConceptId conceptId, ConceptName name, Difficulty difficulty, bool isCustomized, params SubcategoryObject[] subcategories) 
            : base(conceptId)
        {
            if (Difficulty == null)
            {
                throw new ArgumentNullException(nameof(difficulty));
            }
            this.name = name;
            IsCustomized = isCustomized;
            Difficulty = difficulty;
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
