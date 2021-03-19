using System.Linq;

namespace Celebrity.Domain
{
    public static class ConceptMapper
    {
        public static Shared.Concept ToDto(this Concept concept)
        {
            return new Shared.Concept()
            {
                Id = concept.Id,
                Difficulty = concept.Difficulty,
                Type = concept.Type,
                Subcategories = concept.Subcategories.Select(x => new Shared.BaseObject()
                {
                    Id = x.Id,
                    Name = x.ToString()
                }),
                Name = concept.ToString()
            };
        }
    }
}
