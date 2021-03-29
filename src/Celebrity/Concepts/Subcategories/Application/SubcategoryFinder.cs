using System.Threading.Tasks;

namespace Celebrity.Domain
{
    [Service]
    public class SubcategoryFinder
    {
        private readonly ISubcategoryRepository repository;

        public SubcategoryFinder(ISubcategoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Subcategory> Find(SubcategoryId id)
        {
            var category = await repository.GetSubcategory(id);
            if (category is null)
            {
                throw new NotFoundException(id, nameof(Subcategory));
            }
            return category;
        }
    }
}
