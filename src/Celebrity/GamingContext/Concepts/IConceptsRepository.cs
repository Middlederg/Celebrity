using Celebrity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Celebrity.GamingContext
{
    public interface IConceptRepository
    {
        Task<IEnumerable<Concept>> GetConcepts(GameCreationCriteria criteria);
        Task<IEnumerable<Concept>> GetConceptsFromCategory(CategoryValue category);
        Task<IEnumerable<BaseOption<Concept>>> GetConceptsFromGame(GameId id);
    }
}
