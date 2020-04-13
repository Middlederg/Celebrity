using System;
using System.Collections.Generic;

namespace Celebrity
{
    public class Concepts
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DifficultyValue Difficulty { get; set; }
        public ConceptType Type { get; set; }
        public bool IsCustomized { get; set; }

        public ICollection<SubcategoriesInConcepts> SubcategoriesInconcepts { get; set; }

        public Concepts()
        {
            SubcategoriesInconcepts = new HashSet<SubcategoriesInConcepts>();
        }
    }
}
