using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    [Service]
    public class SubcategoryLister
    {
        private readonly ISubcategoryRepository repository;

        public SubcategoryLister(ISubcategoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Subcategory>> ToList()
        {
            var categories = await repository.GetSubcategories();
            return categories;
        }
    }
}
