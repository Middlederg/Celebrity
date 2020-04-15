using System;

namespace Celebrity.Data
{
    public class DeckConcepts
    {
        public Guid Id { get; set; }

        public Guid Concept { get; set; }
        public bool IsGuessed { get; set; }

        public Guid GameId { get; set; }
        public Games Game { get; set; }
    }
}
