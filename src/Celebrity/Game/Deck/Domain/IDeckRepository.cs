using Celebrity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public interface IDeckRepository
    {
        Task<IEnumerable<DeckConcept>> CreateGameConcepts(IEnumerable<DeckConcept> concepts);
        Task<IEnumerable<DeckConcept>> GetConceptsFromGame(GameId id);
    }
}
