using System;

namespace Celebrity.Domain
{
    public class GameId : Id
    {
        public GameId() { }
        public GameId(Guid identificator) : base(identificator) { }
    }
}
