namespace Celebrity.Domain
{
    public static class GameMapper
    {
        public static Shared.Game ToDto(this Game game)
        {
            return new Shared.Game()
            {
                Id = game.Id
            };
        }
    }
}
