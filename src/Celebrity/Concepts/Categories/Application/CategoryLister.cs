using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class CategoryLister
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryLister(ICategoryRepository categoryRepository)
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
