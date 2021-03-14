using System;
using System.Collections.Generic;

namespace Celebrity
{
    public class BaseObject : ValueObject
    {
        private readonly Id id;
        public bool Is(Id id) => this.id == id;

        private readonly string name;

        public BaseObject(Id id, string name)
        {
            this.id = id;
            this.name = name;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return id;
            yield return name;
        }
    }
}
