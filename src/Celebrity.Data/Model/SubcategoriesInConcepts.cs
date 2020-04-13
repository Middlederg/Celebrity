using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public class SubcategoriesInConcepts
    {
        public Guid Id { get; set; }

        public Guid ConceptId { get; set; }
        public Concepts Concepts { get; set; }

        public Guid SubcategoryId { get; set; }
        public Subcategories Subcategories { get; set; }
    }
}
