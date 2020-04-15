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
            throw new NotImplementedException();
        }

        public void DeleteConcept(Concept concept)
        {
            throw new NotImplementedException();
        }

        public void EditConcept(Concept concept)
        {
            throw new NotImplementedException();
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
    }
}
