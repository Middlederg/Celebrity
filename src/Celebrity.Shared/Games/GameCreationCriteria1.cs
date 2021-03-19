using System;

namespace Celebrity.Shared
{
    public class GameCreationCriteria
    {
        public bool IncludeEasy { get;  set;}
        public bool IncludeIntermediate { get; set; }
        public bool IncludeHard { get;  set;}
        public Guid[] SubcategoriesToInclude { get; set; }
    }
}
