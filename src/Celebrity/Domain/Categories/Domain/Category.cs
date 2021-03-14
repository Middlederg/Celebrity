using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Domain
{
    public class Category : ValueObject
    {
        private readonly CategoryValue value;

        public Category(CategoryValue value, params BaseObject[] subcategories)
        {
            this.value = value;
            GetSubcategories = subcategories.ToList();
        }

        public IEnumerable<BaseObject> GetSubcategories { get; }

        public override string ToString() => value.Description();

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }
    }
}
