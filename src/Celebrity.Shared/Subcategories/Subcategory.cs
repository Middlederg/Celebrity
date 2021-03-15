using System.Collections.Generic;

namespace Celebrity.Shared
{
    public class Subcategory
    {
        public string Name { get; set; }
        public CategoryValue Category { get; set; }
        public IEnumerable<BaseObject> Concepts { get; set; }
    }
}
