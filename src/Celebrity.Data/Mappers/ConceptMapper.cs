using System.Linq;

namespace Celebrity.Data
{
    public class ConceptMapper
    {
        private readonly Concepts concept;

        public ConceptMapper(Concepts concept)
        {
            this.concept = concept;
        }

        public Concept Map()
        {
            if (concept == null)
            {
                return null;
            }
            var subcategories = concept.SubcategoriesInconcepts
                .Select(x => new SubcategoryObject(x.SubcategoryId, x.Subcategories.Name))
                .ToArray();
            return Concept.FromDataBase(concept.Id, concept.Name, (int)concept.Difficulty, concept.IsCustomized, subcategories);
        }
    }
}
