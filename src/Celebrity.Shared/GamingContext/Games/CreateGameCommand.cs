using System.Collections.Generic;

namespace Celebrity.Shared
{
    public class CreateGameCommand
    {
        public int TotalRounds { get; set; }
        public int MaximunNumber { get; set; }
        public IEnumerable<CreateTeam> Teams { get; set; }
    }
}
