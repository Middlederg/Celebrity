using Celebrity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Data
{
    public class ConceptsCreator
    {
        private readonly SubcategoryCreator subcategoriasCreator;
        private readonly List<Concepts> concepts = new List<Concepts>();
        private readonly List<SubcategoriesInConcepts> subcategoriesInConcepts = new List<SubcategoriesInConcepts>();

        public ConceptsCreator(ModelBuilder modelBuilder, SubcategoryCreator subcategoriasCreator)
        {
            this.subcategoriasCreator = subcategoriasCreator;

            CreateConcepts();
            modelBuilder.Entity<Concepts>().HasData(concepts);
            modelBuilder.Entity<SubcategoriesInConcepts>().HasData(subcategoriesInConcepts);
        }

        private void Create(string name, DifficultyValue difficulty, params Guid[] subcategoriesId)
        {
            var conceptId = Guid.NewGuid();
            concepts.Add(new Concepts()
            {
                Id = conceptId,
                Name = name,
                Difficulty = difficulty,
                IsCustomized = false
            });
            subcategoriesInConcepts.AddRange(subcategoriesId.Select(id => new SubcategoriesInConcepts()
            {
                Id = Guid.NewGuid(),
                ConceptId = conceptId,
                SubcategoryId = id
            }));
        }

        private void CreateConcepts()
        {
            Antiguedad();
        }

        private void Antiguedad()
        {
            Create("Alejandro Magno", DifficultyValue.Easy, subcategoriasCreator.Antiguedad.Id);
            Create("Hércules", DifficultyValue.Easy, subcategoriasCreator.Antiguedad.Id);
            Create("Amilcar Barca", DifficultyValue.Intermediate, subcategoriasCreator.Antiguedad.Id);
        }
    }
}
