using System.Threading.Tasks;

namespace Celebrity.Domain
{
    [Service]
    public class ConceptFinder
    {
        private readonly IConceptRepository repository;

        public ConceptFinder(IConceptRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Concept> Find(ConceptId id)
        {
            var concept= await repository.GetConcept(id);
            if (concept is null)
            {
                throw new NotFoundException(id, nameof(Concept));
            }
            return concept;
        }
    }
}
