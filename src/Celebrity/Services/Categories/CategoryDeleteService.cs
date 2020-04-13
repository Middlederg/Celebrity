using Celebrity.Repositories;

namespace Celebrity
{
    public class CategoryDeleteService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryDeleteService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Delete(Category category)
        {
            if (category.HasSubcategories)
            {
                throw new DeleteDependencyException(nameof(Category));
            }
            
            categoryRepository.DeleteCategory(category);
        }
    }
}
