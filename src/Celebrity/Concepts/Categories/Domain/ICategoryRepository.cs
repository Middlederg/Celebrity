using Celebrity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public interface ICategoryRepository
    {
        Task<Category> GetCategory(Shared.CategoryValue value);
        Task<IEnumerable<Category>> GetCategories();
    }
}
