using System;
using System.Collections.Generic;

namespace Celebrity
{
    public class Subcategories
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsCustomized { get; set; }

        public ICollection<SubcategoriesInConcepts> SubcategoriesInconcepts { get; set; }

        public Subcategories()
        {
            SubcategoriesInconcepts = new HashSet<SubcategoriesInConcepts>();
        }
    }


}
