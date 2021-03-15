using Celebrity.Shared;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class SubcategoryCreator
    {
        private readonly ISubcategoryRepository subcategoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public SubcategoryCreator(ISubcategoryRepository repository, 
            IUnitOfWork unitOfWork)
        {
            this.subcategoryRepository = repository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Create(CreateSubcategory dto)
        {
            var subcategory = Subcategory.Create(dto.Name, dto.Category);
            await subcategoryRepository.Add(subcategory);
            await unitOfWork.CompleteAsync();
        }
    }
}
