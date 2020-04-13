using Celebrity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Data
{
    public class ConceptsCreator
    {
        private readonly SubcategoriasCreator subcategoriasCreator;

        public ConceptsCreator(SubcategoriasCreator subcategoriasCreator)
        {
            this.subcategoriasCreator = subcategoriasCreator;
        }

        public Concepts Create(string name, DifficultyValue difficulty, params Guid[] subcategoriesId)
        {
            return new Concepts()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Difficulty = difficulty,
                IsCustomized = false,
                SubcategoriesInconcepts = subcategoriesId.Select(id => new SubcategoriesInConcepts()
                {
                    SubcategoryId = id
                }).ToList()
            };
        }

        public IEnumerable<Concepts> Create()
        {
            var list = new List<Concepts>();
            list.AddRange(Antiguedad());
            return list;
        }

        private IEnumerable<Concepts> Antiguedad()
        {
            yield return Create("Alejandro Magno", DifficultyValue.Easy, subcategoriasCreator.Antiguedad.Id);
            yield return Create("Hércules", DifficultyValue.Easy, subcategoriasCreator.Antiguedad.Id);
            yield return Create("Amilcar Barca", DifficultyValue.Intermediate, subcategoriasCreator.Antiguedad.Id);
        }
    }
}
