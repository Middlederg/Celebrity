using Celebrity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Celebrity.Repositories
{
    public interface IConceptsRepository
    {
        IEnumerable<Concept> GetConcept(ConceptId id);
        IEnumerable<Concept> GetConcepts(DeckSelectionCriteria criteria);

        void AddConcept(Concept concept);
        void EditConcept(Concept concept);
        void DeleteConcept(Concept concept);

    }
}
