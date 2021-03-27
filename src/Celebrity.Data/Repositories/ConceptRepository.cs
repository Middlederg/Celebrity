using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Celebrity.Domain;

namespace Celebrity.Data
{
    public class DeckRepository : IDeckRepository
    {
        private readonly CelebrityContext context;

        public ConceptRepository(CelebrityContext context)
        {
            this.context = context;
        }

        public Task<IEnumerable<DeckConcept>> CreateGameConcepts(IEnumerable<Concept> concepts)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DeckConcept>> GetConceptsFromGame(GameId id)
        {
            var concept = await context.deck
               .Include(x => x.Subcategories)
               .AsNoTracking()
               .FirstOrDefaultAsync(x => x.Id == id);

            return concept;
        }

        public Task UpdateConcept(DeckConcept concept)
        {
            throw new NotImplementedException();
        }
    }
    public class ConceptRepository : IConceptRepository
    {
        private readonly CelebrityContext context;

        public ConceptRepository(CelebrityContext context)
        {
            this.context = context;
        }

        public async Task<Concept> GetConcept(ConceptId id)
        {
            var concept = await context.Concepts
               .Include(x => x.Subcategories)
               .AsNoTracking()
               .FirstOrDefaultAsync(x => x.Id == id);

            return concept;
        }

        public async Task<IEnumerable<Concept>> GetAll()
        {
            var list = await context.Concepts
                .Include(x => x.Subcategories)
                .AsNoTracking()
                .ToListAsync();

            return list;
        }

        public async Task<IEnumerable<Concept>> GetAll(IEnumerable<ConceptId> idCollection)
        {
            var list = await context.Concepts
                  .Where(x => idCollection.Contains(x.Id))
                  .Include(x => x.Subcategories)
                  .AsNoTracking()
                  .ToListAsync();

            return list;
        }

        public async Task<IEnumerable<Concept>> GetAllFromCategory(Shared.CategoryValue value)
        {
            var list = await context.Concepts
               .WithCategory(value)
               .Include(x => x.Subcategories)
               .AsNoTracking()
               .ToListAsync();

            return list;
        }

        public async Task<IEnumerable<Concept>> GetAllFromSubcategory(SubcategoryId id)
        {
            var list = await context.Concepts
               .WithSubcategory(id)
               .Include(x => x.Subcategories)
               .AsNoTracking()
               .ToListAsync();

            return list;
        }

        public async Task<IEnumerable<Concept>> GetFromCriteria(Shared.GameCreationCriteria criteria)
        {
            var list = await context.Concepts
              .WithCriteria(criteria)
              .Include(x => x.Subcategories)
              .AsNoTracking()
              .ToListAsync();

            return list;
        }

        public void AddConcept(Concept concept)
        {
            context.Concepts.Add(concept);
        }

        public void Update(Concept concept)
        {
           context.Entry(concept).State = EntityState.Modified;
        }

        public void DeleteConcept(Concept concept)
        {
           context.Concepts.Remove(concept);
           
        }
    }
}
