namespace Celebrity.Data
{
    public class GameInfoMapper
    {
        private readonly Games game;

        public GameInfoMapper(Games game)
        {
            this.game = game;
        }

        public GameInfo Map()
        {
            return new GameInfo(
               id: new GameId(game.Id),
               totalRounds: game.TotalRounds,
               currentRound: game.CurrentRound,
               currentTeam: game.CurrentTeam,
               creationDate: game.CreationDate,
               owner: new UserMapper(game.Owner).Map(),
               percentage: new Percentage(game.Percentage));
        }
    }
}
