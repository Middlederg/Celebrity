using Celebrity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> GetCategory(CategoryValue value);
        Task<IEnumerable<Category>> GetCategories();
    }
}
