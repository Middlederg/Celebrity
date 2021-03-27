using Celebrity.Shared;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class SubcategoryCreator
    {
        private readonly ISubcategoryRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public SubcategoryCreator(ISubcategoryRepository repository, 
            IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<Subcategory> Create(CreateSubcategory dto)
        {
            var subcategory = Subcategory.Create(dto.Name, dto.Category);
            repository.Add(subcategory);
            await unitOfWork.CompleteAsync();
            return subcategory;
        }
    }
}
