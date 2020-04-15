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
        Task<IEnumerable<BaseOption<Concept>>> GetConceptsFromGame(GameId id);

        void AddConcept(Concept concept);
        void EditConcept(Concept concept);
        void DeleteConcept(Concept concept);
    }
}
