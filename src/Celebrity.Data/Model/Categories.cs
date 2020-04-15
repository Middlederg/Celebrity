using System;
using System.Collections.Generic;

namespace Celebrity
{
    public class Categories
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Subcategories> Subcategories { get; set; }

        public Categories()
        {
            Subcategories = new HashSet<Subcategories>();
        }
    }
}
