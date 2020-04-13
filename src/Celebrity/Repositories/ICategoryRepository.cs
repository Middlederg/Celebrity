using Celebrity;
using System;
using System.Collections.Generic;

namespace Celebrity.Repositories
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        void EditCategory(Category category);
        void DeleteCategory(Category category);

        Category GetCategory(Guid id);
        IEnumerable<Category> GetCategories();
    }
}
