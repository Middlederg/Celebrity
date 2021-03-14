using System;
using System.Collections.Generic;

namespace Celebrity.Domain
{
    public class GameCreationCriteria
    {
        public int TotalRounds { get; }
        public int MaximunNumber { get; }
        public bool IncludeEasy { get; }
        public bool IncludeIntermediate { get; }
        public bool IncludeHard { get;  }
        public Guid[] SubcategoriesToInclude { get; }
        public IEnumerable<Team> Teams { get; }

        public GameCreationCriteria(int maximunNumber, int totalRounds, bool inludeEasy, bool includeIntermediate, bool includeHard, 
            Guid[] subcategoriesToInclude, Team[] teams)
        {
            MaximunNumber = maximunNumber;
            TotalRounds = totalRounds;
            IncludeEasy = inludeEasy;
            IncludeIntermediate = includeIntermediate;
            IncludeHard = includeHard;
            SubcategoriesToInclude = subcategoriesToInclude;
            Teams = teams;
        }
    }
}
