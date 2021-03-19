using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public interface ISubcategoryRepository
    {
        Task Add(Subcategory subcategory);
        Task Save(Subcategory subcategory);
        Task DeleteCategory(Subcategory subcategory);

        Task<Subcategory> GetSubcategory(SubcategoryId id);
        Task<IEnumerable<Subcategory>> GetSubcategories();
    }
}
