using System;
using System.Collections.Generic;

namespace Celebrity
{
    public class BaseObject : ValueObject
    {
        public Id Id { get; }
        public bool Is(Id id) => Id == id;

        private readonly string name;

        public BaseObject(Id id, string name)
        {
            Id = id;
            this.name = name;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Id;
            yield return name;
        }
    }
}
