using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public class RoundContext
    {
        public int round;
        public void MoveToNextRound() => round++;

        private readonly IEnumerable<Round> rounds;
        public int TotalRounds => rounds.Count();
        public Round CurrentRound => rounds.ElementAt(round - 1);
        public int CurrentRoundNumber => CurrentRound.Number;
        public bool EndOfGame() => round > rounds.Count();

        public RoundContext(int totalRounds)
        {
            rounds = new RoundFactory(totalRounds).Create();
            round = 1;
        }
    }
}
