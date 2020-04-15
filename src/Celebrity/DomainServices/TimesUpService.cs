namespace Celebrity
{
    public class TimesUpService
    {
        public void Execute(Teams teams, Deck deck)
        {
            teams.MoveToNextTeamTurn();
            if (!deck.IsFinished)
            {
                deck.NextConcept();
            }
        }
    }
}
