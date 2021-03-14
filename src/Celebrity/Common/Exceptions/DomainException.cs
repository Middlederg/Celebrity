using System;

namespace Celebrity
{
    public class DomainException : Exception
    {
        public DomainException(params string[] messages) : base(string.Join(", ", messages)) { }
    }
}
