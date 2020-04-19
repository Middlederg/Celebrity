using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Repositories
{
    public interface ISubcategoryRepository
    {
        void AddSubcategory(Subcategory subcategory);
        Task EditSubcategory(Subcategory subcategory);
        Task DeleteCategory(Subcategory subcategory);

        Task<Subcategory> GetSubcategory(SubcategoryId id);
        Task<IEnumerable<Subcategory>> GetSubcategories();
        //Task<IEnumerable<Subcategory>> GetSubcategories(CategoryValue category);
    }
}
