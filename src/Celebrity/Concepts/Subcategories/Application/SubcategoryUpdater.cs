using System.Collections.Generic;
using System.Threading.Tasks;
using Celebrity.Shared;

namespace Celebrity.Domain
{
    public class SubcategoryUpdater
    {
        private readonly SubcategoryFinder finder;
        private readonly ISubcategoryRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public SubcategoryUpdater(SubcategoryFinder finder, 
            ISubcategoryRepository subcategoryRepository, 
            IUnitOfWork unitOfWork)
        {
            this.finder = finder;
            this.repository = subcategoryRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Edit(SubcategoryId id, UpdateSubcategory dto)
        {
            var subcategory = await finder.Find(id);
            subcategory.EditName(dto.Name);
            subcategory.EditCategory(dto.Category);
            repository.Save(subcategory);
            await unitOfWork.CompleteAsync();
        }
    }
}
