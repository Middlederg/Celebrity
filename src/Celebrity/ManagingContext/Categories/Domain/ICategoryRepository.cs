using Celebrity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.ManagingContext
{
    public interface ICategoryRepository
    {
        Task<Category> GetCategory(CategoryValue value);
        Task<IEnumerable<Category>> GetCategories();
    }
}
