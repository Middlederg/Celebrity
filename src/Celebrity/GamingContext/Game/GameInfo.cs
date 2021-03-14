using System;

namespace Celebrity.GamingContext
{
    public class GameInfo
    {
        public GameId Id { get; }
        public int TotalRounds { get; }
        public int CurrentRound { get; }
        public int CurrentTeam { get; }
        public DateTime CreationDate { get; }
        public User Owner { get; }
        public Percentage Percentage { get; }

        public GameInfo(GameId id, int totalRounds, int currentRound, int currentTeam, DateTime creationDate, User owner, Percentage percentage)
        {
            Id = id;
            TotalRounds = totalRounds;
            CurrentRound = currentRound;
            CurrentTeam = currentTeam;
            CreationDate = creationDate;
            Owner = owner;
            Percentage = percentage;
        }
    }
}
