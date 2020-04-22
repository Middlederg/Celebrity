using Celebrity.Repositories;
using System.Threading.Tasks;

namespace Celebrity
{
    public class SubcategoryDeleteService
    {
        private readonly ISubcategoryRepository subcategoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public SubcategoryDeleteService(ISubcategoryRepository subcategoryRepository, IUnitOfWork unitOfWork)
        {
            this.subcategoryRepository = subcategoryRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Delete(Subcategory subcategory)
        {
            if (subcategory.HasConcepts)
            {
                throw new DeleteDependencyException(nameof(Subcategory));
            }
            
            await subcategoryRepository.DeleteCategory(subcategory);
            await unitOfWork.CompleteAsync();
        }
    }
}
