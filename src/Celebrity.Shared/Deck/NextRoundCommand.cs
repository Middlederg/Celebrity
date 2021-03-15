using System;

namespace Celebrity.Shared
{
    public class NextRoundCommand
    {
        public Guid GameId { get; set; }
        public Guid LastConceptId { get; set; }
    }

}
