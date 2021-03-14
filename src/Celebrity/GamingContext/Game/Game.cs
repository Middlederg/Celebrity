using System;
using System.Collections.Generic;

namespace Celebrity.GamingContext
{
    public class Game : Identity<GameId>
    {
        public RoundContext RoundContext { get; }
        public Deck Deck { get; }

        public Teams Teams { get; }
        public IEnumerable<Team> GetTeams() => Teams.Ranking.Teams;

        public User Owner { get; set; }
        public DateTime CreationDate { get; set; }

        public Game(GameId id, RoundContext roundContext, Deck deck, Teams teams, User owner, DateTime creationDate): base(id)
        {
            RoundContext = roundContext;
            Deck = deck;
            Teams = teams;
            Owner = owner;
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
