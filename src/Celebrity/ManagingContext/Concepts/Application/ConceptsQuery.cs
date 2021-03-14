using Celebrity.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.GamingContext
{
    public class ConceptsQuery
    {
        private readonly IConceptRepository repository;

        public ConceptsQuery(IConceptRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Concept>> GetFromCategory(CategoryValue category)
        {
            var concepts = await repository.GetConceptsFromCategory(category);
            return concepts;
        }
    }
}
