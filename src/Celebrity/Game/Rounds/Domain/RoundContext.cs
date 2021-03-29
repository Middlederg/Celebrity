﻿using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Domain
{
    public class RoundContext
    {
        public int CurrentRoundIndex { get; private set; }
        public void MoveToNextRound() => CurrentRoundIndex++;
        public bool IsEndOfGame() => CurrentRoundIndex > rounds.Count();

        private readonly IEnumerable<Round> rounds;
        public Round CurrentRound => rounds.ElementAt(CurrentRoundIndex - 1);
        public int CurrentRoundNumber => CurrentRound.Number;
        public int TotalRounds => rounds.Count();

        private RoundContext() { }
        public RoundContext(int totalRounds)
        {
            rounds = new RoundFactory(totalRounds).Create();
            CurrentRoundIndex = 1;
        }
    }
}
