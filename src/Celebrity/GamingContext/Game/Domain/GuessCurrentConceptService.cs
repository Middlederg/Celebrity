namespace Celebrity.GamingContext
{
    public class GuessCurrentConceptService
    {
        public void Execute(Deck deck, Teams teams, RoundContext roundContext)
        {
            var currentTeam = teams.CurrentTeam;
            currentTeam.AddPoint(deck.VisibleConcept, roundContext.CurrentRoundNumber);
            deck.Guess();
        }
    }
}
