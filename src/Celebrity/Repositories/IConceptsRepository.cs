using Celebrity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Celebrity.Repositories
{
    public interface IConceptRepository
    {
        Task<Concept> GetConcept(ConceptId id);
        Task<IEnumerable<Concept>> GetConcepts(GameCreationCriteria criteria);
        Task<IEnumerable<Concept>> GetConceptsFromCategory(CategoryValue category);
        Task<IEnumerable<BaseOption<Concept>>> GetConceptsFromGame(GameId id);

        void AddConcept(Concept concept);
        Task EditConcept(Concept concept);
        Task DeleteConcept(Concept concept);
    }
}
