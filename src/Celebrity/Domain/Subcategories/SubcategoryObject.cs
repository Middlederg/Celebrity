using System;
using System.Collections.Generic;

namespace Celebrity
{
    public class SubcategoryObject : ValueObject
    {
        private readonly SubcategoryId id;
        public bool Is(SubcategoryId id) => this.id == id;

        private readonly string name;

        public SubcategoryObject(Guid id, string name)
        {
            this.id = new SubcategoryId(id);
            this.name = name;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return id;
            yield return name;
        }

        public override string ToString() => name;
    }
}
