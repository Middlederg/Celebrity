using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public class RoundContext
    {
        private int currentRound;

        private int currentTeam;

        public RoundContext()
        {
            currentRound = 1;
            currentTeam = 0;
        }
    }

    public class Game
    {
        private int round;
        private int teamTurn;

        private readonly Deck deck;

        private readonly IEnumerable<Team> teams;
        public Team CurrentTeam => teams.ElementAt(teamTurn);
        public Team NextTeam => teams.ElementAt(teamTurn >= teams.Count() - 1 ? 0 : teamTurn + 1);
        public Ranking Ranking => new Ranking(teams);

        public IEnumerable<Round> rounds;
        public Round CurrentRound => rounds.ElementAt(round - 1);

        public Game(List<Concept> concepts, IEnumerable<Team> teams, int totalRounds)
        {
            this.teams = teams.ToList();
            rounds = new RoundFactory(totalRounds).Create();
            teamTurn = 0;
            round = 1;
            deck = new Deck(concepts);
        }

        private void NextTeamTurn() => teamTurn = teamTurn >= teams.Count() - 1 ? 0 : teamTurn + 1;

        public void GuessCurrentConcept()
        {
            CurrentTeam.AddPoint(deck.VisibleConcept(), CurrentRound.Number);
            deck.Guess();
        }

        public void NextRound()
        {
            round++;
            deck.Reset();
        }

        public void AvanzarTurnoSiguienteEquipo()
        {
            NextTeamTurn();
            if (!deck.IsFinished())
            {
                deck.NextConcept();
            }
        }

        public bool EndOfRound() => deck.IsFinished();
        public bool EndOfGame() => round > rounds.Count();
    }
}
