using System;

namespace Celebrity
{
    public abstract class Identity<T> where T : Id
    {
        private readonly Id id;
        public T Id => id as T;

        protected Identity() { }
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
