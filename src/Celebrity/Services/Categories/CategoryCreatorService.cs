using Celebrity.Repositories;

namespace Celebrity
{
    public class CategoryCreatorService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryCreatorService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Create(string name)
        {
            var category = Category.Create(name);
            categoryRepository.AddCategory(category);
        }
    }
}
