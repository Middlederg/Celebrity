namespace Celebrity.Shared
{
    public static class GameConceptEndpoints
    {
        public const string Base = "api/game-concepts";
        public static string Guess => $"{Base}/guess";
        public static string Next => $"{Base}/next";
        public static string Timesup => $"{Base}/timesup";
    }
}
