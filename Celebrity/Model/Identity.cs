using System;

namespace Celebrity.Model
{
    public class Identity
    {
        public Guid Id { get; }

        public Identity(Guid id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Identity identity)
                return identity.Id == Id;
            return false;
        }
        public override int GetHashCode() => Id.GetHashCode();
    }
}
