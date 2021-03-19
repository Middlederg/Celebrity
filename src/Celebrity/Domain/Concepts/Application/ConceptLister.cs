using Celebrity.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    [Service]
    public class ConceptLister
    {
        private readonly IConceptRepository repository;

        public ConceptLister(IConceptRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Concept>> GetFromCategory(int categoryId)
        {
            var categoryValue = (CategoryValue)categoryId;
            var concepts = await repository.GetAllFromCategory(categoryValue);
            return concepts;
        }

        public async Task<IEnumerable<Concept>> GetFromSubcategory(int categoryId)
        {
            var categoryValue = (CategoryValue)categoryId;
            var concepts = await repository.GetAllFromCategory(categoryValue);
            return concepts;
        }

        public async Task<IEnumerable<Concept>> GetFromSubcategory(SubcategoryId id)
        {
            var concepts = await repository.GetAllFromSubcategory(id);
            return concepts;
        }

    }
}
