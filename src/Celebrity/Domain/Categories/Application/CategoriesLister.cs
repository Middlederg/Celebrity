using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class CategoriesLister
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesLister(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ToList()
        {
            var categories = await categoryRepository.GetCategories();
            return categories;
        }
    }
}
