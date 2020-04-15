using System;

namespace Celebrity.Data
{
    public class TeamPoints
    {
        public Guid Id { get; set; }
        public int Round { get; set; }
        public Guid Concept { get; set; }

        public Guid TeamId { get; set; }
        public TeamsInGame Team { get; set; }
    }
}
