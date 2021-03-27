using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class ConceptGuesser
    {
        private readonly GameFinder gameFinder;

        public async Task Guess(GameId gameId)
        {
            var game = await gameFinder.Find(gameId);
            var currentTeam = game.CurrentTeam();
            //currentTeam.AddPoint(game.VisibleConcept, roundContext.CurrentRoundNumber);
            //deck.Guess();
        }
    }
}
