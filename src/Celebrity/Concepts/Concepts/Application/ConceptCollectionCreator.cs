using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    [Service]
    public class ConceptCollectionCreator
    {
        private readonly ISubcategoryRepository subCategoryRepository;
        private readonly IConceptRepository conceptRepository;
        private readonly IUnitOfWork unitOfWork;

        public ConceptCollectionCreator(ISubcategoryRepository subCategoryRepository, 
            IConceptRepository conceptRepository,
            IUnitOfWork unitOfWork)
        {
            this.subCategoryRepository = subCategoryRepository;
            this.conceptRepository = conceptRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Concept>> Create(IEnumerable<Shared.CreateConcept> dtoCollection)
        {
            var categories = await subCategoryRepository.GetSubcategories();
            var results = new List<Concept>();
            foreach (var dto in dtoCollection)
            {
                var subcategories = GetSubCategory(categories, dto.SubcategoryId).ToList();
                var concept = new Concept(new ConceptId(), new ConceptName(dto.Name), dto.Difficulty, dto.Type, subcategories);
                conceptRepository.AddConcept(concept);
                results.Add(concept);
            }
            await unitOfWork.CompleteAsync();
            return results;
        }

        private IEnumerable<Subcategory> GetSubCategory(IEnumerable<Subcategory> categories, Guid? subcategoryId)
        {
            if (!subcategoryId.HasValue)
            {
                yield break;
            }
            var subcategory = categories.FirstOrDefault(x => x.Id == subcategoryId.Value);

            yield return subcategory; 
        }
    }

}
