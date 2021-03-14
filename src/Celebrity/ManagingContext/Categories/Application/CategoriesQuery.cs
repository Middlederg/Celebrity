using Celebrity.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.ManagingContext
{
    public class CategoriesQuery
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesQuery(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> Execute()
        {
            var categories = await categoryRepository.GetCategories();
            return categories;
        }
    }
}
