using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Domain
{
    public class Game : Identity<GameId>
    {
        public RoundContext RoundContext { get; private set; }
        public ICollection<DeckConcept> DeckConcepts { get; private set; }

        public ICollection<Team> Teams { get; private set; }

        public DateTime CreationDate { get; private set; }

        public Game(GameId id, RoundContext roundContext, IEnumerable<DeckConcept> deckConcepts, IEnumerable<Team> teams, DateTime creationDate): base(id)
        {
            RoundContext = roundContext;
            DeckConcepts = deckConcepts.ToList();
            Teams = teams.ToList();
            CreationDate = creationDate;
        }

        public Percentage GetPercentage()
        {
            var deck = new Deck(DeckConcepts);
            var numerator = DeckConcepts.Count * (RoundContext.CurrentRoundNumber - 1);
            numerator += deck.GuessedCount;
            var denominator = deck.ConceptCount * RoundContext.TotalRounds;
            return new Percentage(numerator, denominator);
        }
    }
}
