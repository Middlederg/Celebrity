using Celebrity.Repositories;

namespace Celebrity
{
    public class CategoryEditorService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryEditorService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Edit(Category category, string newName)
        {
            category.EditName(newName);
            categoryRepository.EditCategory(category);
        }
    }
}
