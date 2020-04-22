using Celebrity.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity
{
    public class ConceptCreatorService
    {
        private readonly IConceptRepository conceptRepository;
        private readonly IUnitOfWork unitOfWork;

        public ConceptCreatorService(IConceptRepository conceptRepository, IUnitOfWork unitOfWork)
        {
            this.conceptRepository = conceptRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Create(IEnumerable<Concept> concepts)
        {
            foreach (var concept in concepts)
            {
                conceptRepository.AddConcept(concept);
            }
            await unitOfWork.CompleteAsync();
        }
    }
}
