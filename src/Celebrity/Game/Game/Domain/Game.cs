using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Domain
{
    public class Game : Identity<GameId>
    {
        public RoundContext RoundContext { get; private set; }

        public ICollection<DeckConcept> DeckConcepts { get; private set; }
        public void AddConcepts(IEnumerable<DeckConcept> concepts)
        {
            foreach (var concept in concepts) DeckConcepts.Add(concept);
        }

        public int CurrentTurn { get; private set; }
        public ICollection<Team> Teams { get; private set; }
        public Team CurrentTeam() => Teams.ElementAt(CurrentTurn);
        public Ranking Ranking() => new Ranking(Teams);
        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        public Team MoveToNextTurn()
        {
            var turn = new TurnProcessor(Teams, CurrentTurn);
            var nextTeam = turn.NextTeam;
            CurrentTurn = turn.NextTurn;
            return nextTeam;
        }

        public DateTime CreationDate { get; private set; }

        public Game(GameId id, int totalRounds, DateTime creationDate): base(id)
        {
            RoundContext = new RoundContext(totalRounds);
            DeckConcepts = new List<DeckConcept>();
            Teams = new List<Team>();
            CreationDate = creationDate;
            CurrentTurn = 0;
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
