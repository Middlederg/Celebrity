using System.Collections.Generic;

namespace Celebrity.Repositories
{
    public class DeckSelectionCriteria
    {
        public int MaximunNumber { get; }
        public bool InludeEasy { get; }
        public bool IncludeIntermediate { get; }
        public bool IncludeHard { get;  }
        public IEnumerable<SubcategoryId> SubcategoriesToInclude { get; }

        public DeckSelectionCriteria(int maximunNumber, bool inludeEasy, bool includeIntermediate, bool includeHard, IEnumerable<SubcategoryId> subcategoriesToInclude)
        {
            MaximunNumber = maximunNumber;
            InludeEasy = inludeEasy;
            IncludeIntermediate = includeIntermediate;
            IncludeHard = includeHard;
            SubcategoriesToInclude = subcategoriesToInclude;
        }
    }
}
