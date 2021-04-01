using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    [Service]
    public class SubcategoriesInConceptUpdater
    {
        private readonly ConceptFinder finder;
        private readonly IConceptRepository repository;

        public SubcategoriesInConceptUpdater(ConceptFinder finder, IConceptRepository repository)
        {
            this.finder = finder;
            this.repository = repository;
        }

        public async Task Update(ConceptId conceptId, IEnumerable<Guid> subcategoryCollection)
        {
            await finder.Find(conceptId);
            repository.UpdateSubcategories(conceptId, subcategoryCollection);
        }
    }
}
