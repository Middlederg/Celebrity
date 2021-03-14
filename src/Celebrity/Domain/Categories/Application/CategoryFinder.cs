using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class CategoryFinder
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryFinder(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<Category> Find(CategoryValue value)
        {
            var category = await categoryRepository.GetCategory(value);

            if (category is null)
            {
                throw new NotFoundException((int)value, nameof(Category));
            }
            return category;
        }
    }
}
