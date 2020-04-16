using Celebrity.Repositories;
using System.Threading.Tasks;

namespace Celebrity
{
    public class SubcategoryEditorService
    {
        private readonly ISubcategoryRepository subcategoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public SubcategoryEditorService(ISubcategoryRepository subcategoryRepository, IUnitOfWork unitOfWork)
        {
            this.subcategoryRepository = subcategoryRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Edit(Subcategory category)
        {
            subcategoryRepository.EditSubcategoryName(category);
            await unitOfWork.CompleteAsync();
        }
    }
}
