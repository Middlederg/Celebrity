using System.Threading.Tasks;

namespace Celebrity.Repositories
{
    public interface ISubcategoryRepository
    {
        void AddSubcategory(Subcategory subcategory);
        Task EditSubcategoryName(Subcategory subcategory);
        Task DeleteCategory(Subcategory subcategory);
    }
}
