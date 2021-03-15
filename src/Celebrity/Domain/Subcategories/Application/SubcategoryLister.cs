using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class SubcategoryLister
    {
        private readonly ISubcategoryRepository repository;

        public SubcategoryLister(ISubcategoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Shared.Subcategory>> ToList()
        {
            var categories = await repository.GetSubcategories();
            return categories;
        }
    }
}
