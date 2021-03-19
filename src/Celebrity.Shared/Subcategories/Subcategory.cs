using System;
using System.Collections.Generic;

namespace Celebrity.Shared
{
    public class Subcategory
    {
        public const int NameMaxLength = 100;

        public Guid Id { get; set; }
        public string Name { get; set; }
        public CategoryValue Category { get; set; }
        public IEnumerable<BaseObject> Concepts { get; set; }
    }
}
