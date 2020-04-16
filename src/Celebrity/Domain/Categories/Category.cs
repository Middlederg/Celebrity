using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public class Category : ValueObject
    {
        private readonly CategoryValue value;

        public Category(CategoryValue value, params SubcategoryObject[] subcategories)
        {
            this.value = value;
            categories = subcategories.ToList();
        }

        private readonly List<SubcategoryObject> categories;
        public void AddSubcategory(SubcategoryObject subcategory) => categories.Add(subcategory);
        public IEnumerable<SubcategoryObject> GetSubcategories() => categories.ToList();
        public bool HasSubcategories => categories.Any();

        public override string ToString() => value.Description();

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }
    }
}
