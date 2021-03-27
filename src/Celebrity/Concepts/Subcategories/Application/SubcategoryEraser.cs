using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class SubcategoryEraser
    {
        private readonly ISubcategoryRepository subcategoryRepository;
        private readonly SubcategoryFinder finder;
        private readonly IUnitOfWork unitOfWork;

        public SubcategoryEraser(ISubcategoryRepository subcategoryRepository, 
            SubcategoryFinder finder, 
            IUnitOfWork unitOfWork)
        {
            this.subcategoryRepository = subcategoryRepository;
            this.finder = finder;
            this.unitOfWork = unitOfWork;
        }

        public async Task Delete(SubcategoryId id)
        {
            var subcategory = await finder.Find(id);

            if (subcategory.HasConcepts)
            {
                throw new DeleteDependencyException(nameof(Subcategory));
            }
            
            subcategoryRepository.Delete(subcategory);
            await unitOfWork.CompleteAsync();
        }
    }
}
