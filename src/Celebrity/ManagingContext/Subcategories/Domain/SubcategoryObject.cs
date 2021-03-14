using System;
using System.Collections.Generic;

namespace Celebrity.ManagingContext
{
    public class SubcategoryObject : ValueObject
    {
        public SubcategoryId Id { get; }
        public bool Is(SubcategoryId id) => Id == id;

        private readonly string name;

        public SubcategoryObject(Guid id, string name)
        {
            Id = new SubcategoryId(id);
            this.name = name;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Id;
            yield return name;
        }

        public override string ToString() => name;
    }
}
