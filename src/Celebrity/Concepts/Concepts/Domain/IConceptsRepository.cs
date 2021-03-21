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
        Task<IEnumerable<Concept>> GetAll(IEnumerable<ConceptId> idCollection);
        Task<IEnumerable<Concept>> GetAllFromCategory(Shared.CategoryValue value);
        Task<IEnumerable<Concept>> GetAllFromSubcategory(SubcategoryId id);
        Task<IEnumerable<Concept>> GetFromCriteria(Shared.GameCreationCriteria criteria);

        void AddConcept(Concept concept);
        void Update(Concept concept);
        void DeleteConcept(Concept concept);
    }
}
