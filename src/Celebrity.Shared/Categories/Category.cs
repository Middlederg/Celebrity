using System.Collections.Generic;

namespace Celebrity.Shared
{
    public class Category
    {
        public CategoryValue Value { get; set; }
        public IEnumerable<BaseObject> Subcategories { get; set; }
    }
}
