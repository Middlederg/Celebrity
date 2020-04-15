using Celebrity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Repositories
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        void EditCategory(Category category);
        void DeleteCategory(Category category);

        Task<Category> GetCategory(Guid id);
        Task<IEnumerable<Category>> GetCategories();
    }
}
