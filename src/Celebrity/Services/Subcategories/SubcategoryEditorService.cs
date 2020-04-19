using Celebrity.Repositories;
using System.Collections.Generic;
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

        public async Task Edit(IEnumerable<Subcategory> subcategories)
        {
            foreach (var subcategory in subcategories)
            {
                await subcategoryRepository.EditSubcategory(subcategory);
            }
            await unitOfWork.CompleteAsync();
        }
    }
}
