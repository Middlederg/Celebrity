using System;
using System.Collections.Generic;

namespace Celebrity.Data
{
    public class TeamsInGame
    {
        public Guid Id { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public Color Color { get; set; }
        public int Fails { get; set; }

        public Guid GameId { get; set; }
        public Games Game { get; set; }

        public ICollection<TeamPoints> Points { get; set; }

        public TeamsInGame()
        {
            Points = new HashSet<TeamPoints>();
        }
    }
}
