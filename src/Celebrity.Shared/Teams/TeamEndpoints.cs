using System;

namespace Celebrity.Shared
{
    public static class TeamEndpoints
    {
        public const string Base = "api/teams";
    }

    public class Team
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }

        public Point Points { get; set; }

        public int Fails { get; set; }
    }
}
