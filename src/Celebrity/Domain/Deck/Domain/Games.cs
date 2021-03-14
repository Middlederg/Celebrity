using System;
using System.Collections.Generic;

namespace Celebrity.Data
{
    public class Games
    {
        public Guid Id { get; set; }
        public int TotalRounds { get; set; }
        public int CurrentRound { get; set; }
        public int CurrentTeam { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Percentage { get; set; }

        public string OwnerId { get; set; }
        public Users Owner { get; set; }

        public ICollection<DeckConcepts> Concepts { get; set; }
        public ICollection<TeamsInGame> Teams { get; set; }
        public ICollection<LoadedGames> LoadedGames { get; set; }

        public Games()
        {
            Concepts = new HashSet<DeckConcepts>();
            Teams = new HashSet<TeamsInGame>();
            LoadedGames = new HashSet<LoadedGames>();
        }
    }
}
