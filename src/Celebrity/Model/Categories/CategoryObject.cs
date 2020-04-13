using System;
using System.Collections.Generic;

namespace Celebrity
{
    public class CategoryObject : ValueObject
    {
        private readonly CategoryId id;
        public bool Is(CategoryId id) => this.id == id;

        private readonly string name;

        public CategoryObject(Guid id, string name)
        {
            this.id = new CategoryId(id);
            this.name = name;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return id;
            yield return name;
        }
    }
}
