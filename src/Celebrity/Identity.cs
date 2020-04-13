using System;

namespace Celebrity
{
    public abstract class Identity<T> where T : Id
    {
        private readonly Id id;
        public T GetId => id as T;

        public Identity(Id id)
        {
            this.id = id;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Identity<T> identity)
                return identity.id == id;
            return false;
        }

        public override int GetHashCode() => id.GetHashCode();
    }
}
