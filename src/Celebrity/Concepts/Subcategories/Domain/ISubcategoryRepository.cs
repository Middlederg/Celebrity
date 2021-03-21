using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public interface ISubcategoryRepository
    {
        void Add(Subcategory subcategory);
        void Save(Subcategory subcategory);
        void DeleteCategory(Subcategory subcategory);

        Task<Subcategory> GetSubcategory(SubcategoryId id);
        Task<IEnumerable<Subcategory>> GetSubcategories();
    }
}
