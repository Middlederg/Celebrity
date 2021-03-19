using Celebrity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Domain
{
    public class Category : ValueObject
    {
        public CategoryValue Value { get; }

        public Category(CategoryValue value, params BaseObject[] subcategories)
        {
            Value = value;
            Subcategories = subcategories.ToList();
        }

        public IEnumerable<BaseObject> Subcategories { get; }

        public override string ToString() => Value.Description();

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
