using Celebrity.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class ConceptCreatorService
    {
        private readonly IDeckRepository conceptRepository;
        private readonly IUnitOfWork unitOfWork;

        public ConceptCreatorService(IDeckRepository conceptRepository, IUnitOfWork unitOfWork)
        {
            this.conceptRepository = conceptRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Create(IEnumerable<DeckConcept> concepts)
        {
            foreach (var concept in concepts)
            {
                conceptRepository.AddConcept(concept);
            }
            await unitOfWork.CompleteAsync();
        }
    }
}
