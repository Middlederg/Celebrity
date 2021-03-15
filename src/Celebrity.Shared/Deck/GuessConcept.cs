using System;

namespace Celebrity.Shared
{
    public class GuessConceptCommand
    {
        public Guid GameId { get; set; }
        public Guid ConceptId { get; set; }
        public Guid TeamId { get; set; }
    }

}
