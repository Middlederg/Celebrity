using System;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    [Service]
    public class ConceptEraser
    {
        private readonly ConceptFinder finder;
        private readonly IConceptRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public ConceptEraser(ConceptFinder finder, IConceptRepository repository, IUnitOfWork unitOfWork)
        {
            this.finder = finder;
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Delete(ConceptId id)
        {
            var concept = await finder.Find(id);
            await repository.DeleteConcept(concept);
            await unitOfWork.CompleteAsync();
        }
    }
}
