using Celebrity.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class ConceptsFromCategoryLister
    {
        private readonly IDeckRepository repository;

        public ConceptsFromCategoryLister(IDeckRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<DeckConcept>> GetFromCategory(CategoryValue category)
        {
            var concepts = await repository.GetConceptsFromCategory(category);
            return concepts;
        }
    }
}
