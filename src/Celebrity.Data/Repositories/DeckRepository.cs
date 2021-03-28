using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Celebrity.Domain;

namespace Celebrity.Data
{
    public class DeckRepository : IDeckRepository
    {
        private readonly CelebrityContext context;

        public DeckRepository(CelebrityContext context)
        {
            this.context = context;
        }

        public async Task<DeckConcept> GetConcept(DeckConceptId id)
        {
            var result = await context.DeckConcepts
               .Include(x => x.Subcategories)
               .FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<IEnumerable<DeckConcept>> GetConceptsFromGame(GameId id)
        {
            var concepts = await context.DeckConcepts
               .Include(x => x.Subcategories)
               .AsNoTracking()
               .Where(x => x.GameId == id)
               .ToListAsync();

            return concepts;
        }

        public void UpdateConcept(DeckConcept concept)
        {
            context.Entry(concept).State = EntityState.Modified;
        }
    }
}
