using System;

namespace Celebrity.Domain
{
    public class TeamId : Id
    {
        public TeamId() { }
        public TeamId(Guid identificator) : base(identificator) { }
    }
}
