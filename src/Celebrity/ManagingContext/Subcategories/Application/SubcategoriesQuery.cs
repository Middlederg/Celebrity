using Celebrity.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.ManagingContext
{
    public class SubcategoriesQuery
    {
        private readonly ISubcategoryRepository repository;

        public SubcategoriesQuery(ISubcategoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Subcategory>> GetAll()
        {
            var categories = await repository.GetSubcategories();
            return categories;
        }
    }
}
