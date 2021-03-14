using System;

namespace Celebrity.Domain
{
    public class PointId : Id
    {
        public PointId() { }
        public PointId(Guid identificator) : base(identificator) { }
    }
}
