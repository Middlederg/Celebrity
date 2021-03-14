using System;
using System.Collections.Generic;

namespace Celebrity.Domain
{
    public class Game : Identity<GameId>
    {
        public RoundContext RoundContext { get; private set; }
        public ICollection<DeckConcept> Deck { get; private set; }

        public Teams Teams { get; private set; }

        public DateTime CreationDate { get; set; }

        public Game(GameId id, RoundContext roundContext, Deck deck, Teams teams, DateTime creationDate): base(id)
        {
            RoundContext = roundContext;
            Deck = deck;
            Teams = teams;
            CreationDate = creationDate;
        }

        public GameInfo GetGameInfo()
        {
            return new GameInfo(
                id: Id,
                totalRounds: RoundContext.TotalRounds,
                currentRound: RoundContext.CurrentRoundNumber,
                currentTeam: Teams.Turn,
                creationDate: CreationDate,
                owner: Owner,
                percentage: GetPercentage());
        }

        public Percentage GetPercentage()
        {
            var numerator = Deck.ConceptCount * (RoundContext.CurrentRoundNumber - 1);
            numerator += Deck.GuessedConceptCount;
            var denominator = Deck.ConceptCount * RoundContext.TotalRounds;
            return new Percentage(numerator, denominator);
        }
    }
}
