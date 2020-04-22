using System;
using System.Collections.Generic;
using System.Linq;

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

        public void AddSubcategory(Guid subcategoryId)
        {
            if (!SubcategoriesInconcepts.Any(x => x.SubcategoryId == subcategoryId))
            {
                SubcategoriesInconcepts.Add(new SubcategoriesInConcepts()
                {
                    SubcategoryId = subcategoryId
                });
            }
        }
        public void UpdateSubcategorias(IEnumerable<Guid> subcategories)
        {
            var elementsToRemove = SubcategoriesInconcepts.Where(x => !subcategories.Contains(x.SubcategoryId));
            foreach (var subcategorInConcept in SubcategoriesInconcepts.ToList().Where(x => elementsToRemove.Contains(x)))
            {
                SubcategoriesInconcepts.Remove(subcategorInConcept);
            }

            foreach (var newSubcategory in subcategories)
            {
                AddSubcategory(newSubcategory);
            }
        }
    }
}
