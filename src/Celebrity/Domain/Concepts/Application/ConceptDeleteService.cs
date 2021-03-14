using Celebrity.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class ConceptDeleteService
    {
        private readonly IDeckRepository conceptRepository;
        private readonly IGameRepository gameRepository;
        private readonly IUnitOfWork unitOfWork;

        public ConceptDeleteService(IDeckRepository conceptRepository, IGameRepository gameRepository, IUnitOfWork unitOfWork)
        {
            this.conceptRepository = conceptRepository;
            this.gameRepository = gameRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Delete(DeckConcept concept)
        {
            var games = await gameRepository.GetGamesWithConcept(concept.Id);
            if (games.Any())
            {
                string message = $"Games: {string.Join(Environment.NewLine, games.Select(x => $"Created by {x.Owner} in {x.CreationDate.ToShortDateString()} ({x.Percentage})"))}";
                throw new DeleteDependencyException(nameof(DeckConcept), message);
            }

            await conceptRepository.DeleteConcept(concept);
            await unitOfWork.CompleteAsync();
        }
    }
}
