using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    [Service]
    public class ConceptCollectionUpdater
    {
        private readonly IConceptRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public ConceptCollectionUpdater(IConceptRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Edit(IEnumerable<Shared.UpdateConcept> dtoCollection)
        {
            var idCollection = dtoCollection
                .Select(x => new ConceptId(x.Id))
                .ToList();

            var concepts = await repository.GetAll(idCollection);

            foreach (var dto in dtoCollection)
            {
                var concept = concepts.FirstOrDefault(x => x.Id == dto.Id);
                if (concept != null)
                {
                    concept.UpdateName(dto.Name);
                    concept.UpdateType(dto.Type);
                    concept.UpdateDifficulty(dto.Difficulty);
                }
                await repository.Update(concept);
            }
            await unitOfWork.CompleteAsync();
        }
    }
}
