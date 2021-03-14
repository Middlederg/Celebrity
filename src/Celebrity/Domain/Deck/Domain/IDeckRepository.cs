using Celebrity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public interface IDeckRepository
    {
        Task<IEnumerable<DeckConcept>> GetConcepts(GameCreationCriteria criteria);
        Task<IEnumerable<DeckConcept>> GetConceptsFromCategory(CategoryValue category);
        Task<IEnumerable<BaseOption<DeckConcept>>> GetConceptsFromGame(GameId id);
    }
}
