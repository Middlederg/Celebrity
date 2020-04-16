using Celebrity.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity
{
    public class SubcategoryCreatorService
    {
        private readonly ISubcategoryRepository subcategoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public SubcategoryCreatorService(ISubcategoryRepository subcategoryRepository, IUnitOfWork unitOfWork)
        {
            this.subcategoryRepository = subcategoryRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Create(string name, CategoryValue categoryValue)
        {
            var subcategory = Subcategory.Create(name, categoryValue);
            subcategoryRepository.AddSubcategory(subcategory);
            await unitOfWork.CompleteAsync();
        }
    }
}
