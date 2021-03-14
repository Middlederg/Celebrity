using System;

namespace Celebrity
{
    public class Id
    {
        private readonly Guid identificator;

        protected Id()
        {
            identificator = new Guid();
        }

        protected Id(Guid identificator)
        {
            this.identificator = identificator;
        }

        public static implicit operator Guid(Id value) => value.identificator;

        public override bool Equals(object obj)
        {
            if (obj != null || GetType().Equals(obj.GetType()))
                return false;

            if (obj is Id identity)
                return identity.identificator.Equals(identificator);

            return false;
        }

        public override int GetHashCode() => identificator.GetHashCode();

        protected static bool EqualOperator(Id left, Id right)
        {
            if (left is null ^ right is null)
            {
                return false;
            }

            return left is null || left.Equals(right);
        }

        protected static bool NotEqualOperator(Id left, Id right)
        {
            return !EqualOperator(left, right);
        }

        public override string ToString() => identificator.ToString();
    }
}
