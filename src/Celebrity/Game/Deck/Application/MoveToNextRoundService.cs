namespace Celebrity.Domain
{
    public class MoveToNextRoundService
    {
        public bool IsNextRoundTime(Deck deck, RoundContext roundContext) => deck.IsFinished;
        public void Execute(Deck deck, RoundContext roundContext)
        {
            roundContext.MoveToNextRound();
            //deck.Reset();
        }
    }
}
