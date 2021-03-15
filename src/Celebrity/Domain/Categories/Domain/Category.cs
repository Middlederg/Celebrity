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
            GetSubcategories = subcategories.ToList();
        }

        public IEnumerable<BaseObject> GetSubcategories { get; }

        public override string ToString() => Value.Description();

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }

    public static class CategoryMapper
    {
        public static Shared.Category ToDto(this Category category)
        {
            return new Shared.Category()
            {
                Value = category.GetSubcategories
            };
        }
    }
}
