using Celebrity.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity
{
    public class ConceptEditorService
    {
        private readonly IConceptRepository conceptRepository;
        private readonly IUnitOfWork unitOfWork;

        public ConceptEditorService(IConceptRepository conceptRepository, IUnitOfWork unitOfWork)
        {
            this.conceptRepository = conceptRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Edit(IEnumerable<Concept> concepts)
        {
            foreach (var concept in concepts)
            {
                await conceptRepository.EditConcept(concept);
            }
            await unitOfWork.CompleteAsync();
        }
    }
}
