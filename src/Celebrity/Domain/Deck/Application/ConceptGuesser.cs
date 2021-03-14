namespace Celebrity.Domain
{
    public class ConceptGuesser
    {
        private readonly IGameRepository gameRepository;
        public void Guess(GameId gameId)
        {
            var game = gameRepository.Get(gameId);
            command.GameId
            var currentTeam = teams.CurrentTeam;
            currentTeam.AddPoint(deck.VisibleConcept, roundContext.CurrentRoundNumber);
            deck.Guess();
        }
    }
}
