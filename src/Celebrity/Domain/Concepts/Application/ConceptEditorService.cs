using Celebrity.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class ConceptEditorService
    {
        private readonly IDeckRepository conceptRepository;
        private readonly IUnitOfWork unitOfWork;

        public ConceptEditorService(IDeckRepository conceptRepository, IUnitOfWork unitOfWork)
        {
            this.conceptRepository = conceptRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Edit(IEnumerable<DeckConcept> concepts)
        {
            foreach (var concept in concepts)
            {
                await conceptRepository.EditConcept(concept);
            }
            await unitOfWork.CompleteAsync();
        }
    }
}
