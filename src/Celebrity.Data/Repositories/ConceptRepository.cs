using Celebrity.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Celebrity.Data
{
    public class ConceptRepository : IConceptRepository
    {
        private readonly CelebrityContext context;

        public ConceptRepository(CelebrityContext context)
        {
            this.context = context;
        }

        public void AddConcept(Concept concept)
        {
            var concepts = new Concepts()
            {
                Id = Guid.NewGuid(),
                Name = concept.ToString(),
                
            };
            foreach (var subcategory in concept.Subcategories)
            {
                concepts.AddSubcategory(subcategory.Id);
            }
            context.Concepts.Add(concepts);
        }

        public async Task DeleteConcept(Concept concept)
        {
            var concepts = await context.Concepts.FindAsync((Guid)concept.Id);
            if (concepts != null)
            {
                context.Concepts.Remove(concepts);
            }
        }

        public async Task EditConcept(Concept concept)
        {
            var concepts = await context.Concepts
                .Include(x => x.SubcategoriesInconcepts)
                .FirstOrDefaultAsync(x => x.Id.Equals(concept.Id));

            if (concepts != null)
            {
                concepts.Name = concept.ToString();
                concepts.Difficulty = concept.Difficulty.Value;
                concepts.Type = concept.Type;
                concepts.UpdateSubcategorias(concept.Subcategories.Select(x => (Guid)x.Id));
                context.Entry(concepts).State = EntityState.Modified;
            }
        }

        public async Task<Concept> GetConcept(ConceptId id)
        {
            var concept = await context.Concepts
              .Include(x => x.SubcategoriesInconcepts)
              .ThenInclude(x => x.Subcategories)
              .FirstOrDefaultAsync(x => x.Id == id);

            return new ConceptMapper(concept).Map();
        }

        public async Task<IEnumerable<Concept>> GetConcepts(GameCreationCriteria criteria)
        {
            var list = await context.Concepts
                .WithCriteria(criteria)
                .Include(x => x.SubcategoriesInconcepts)
                .ThenInclude(x => x.Subcategories)
                .ToListAsync();

            return list.Select(x => new ConceptMapper(x).Map());
        }

        public async Task<IEnumerable<BaseOption<Concept>>> GetConceptsFromGame(GameId id)
        {
            var concepts = await context.DeckConcepts
                .Where(x => x.GameId == id)
                .ToListAsync();

            var conceptIds = concepts.Select(x => x.Concept);

            var conceptList = context.Concepts
                .Where(x => conceptIds.Contains(x.Id))
                .Include(x => x.SubcategoriesInconcepts)
                .ThenInclude(x => x.Subcategories)
                .AsEnumerable()
                .Select(origin => {
                    var currentConcept = concepts.First(x => x.Id == origin.Id);
                    var concept = new ConceptMapper(origin).Map();
                    return new BaseOption<Concept>(concept, currentConcept.IsGuessed);
                 });
            return conceptList;
        }

        public async Task<IEnumerable<Concept>> GetConceptsFromCategory(CategoryValue category)
        {
            var list = await context.Concepts
             .WithCategory(category)
             .Include(x => x.SubcategoriesInconcepts)
             .ThenInclude(x => x.Subcategories)
             .ToListAsync();

            return list.Select(x => new ConceptMapper(x).Map());
        }
    }
}
