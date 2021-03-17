using System;

namespace Celebrity.Shared
{
    public class Concept
    {
        public const int NameMaxLength = 200;

        public Guid Id { get; set; }

        public string Name { get; set; }

        public Difficulty Difficulty { get; set; }

        public ConceptType Type { get; set; }
    }
}