using Celebrity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public interface IConceptRepository
    {
        Task<Concept> GetConcept(ConceptId id);
        Task<IEnumerable<Concept>> GetAll();

        void AddConcept(Concept concept);
        Task EditConcept(Concept concept);
        Task DeleteConcept(Concept concept);
    }
}
