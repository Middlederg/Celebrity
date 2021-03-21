using System;

namespace Celebrity.Shared
{
    public class Team
    {
        public const int NameMaxLength = 25;

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }

        public Point Points { get; set; }

        public int Fails { get; set; }
    }
}
