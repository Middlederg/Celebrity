using Celebrity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Domain
{
    public class Subcategory : Identity<SubcategoryId>
    {
        public SubcategoryName Name { get; private set; }
        public void EditName(string newName) => new SubcategoryName(newName);

        public CategoryValue Category { get; private set; }
        public void EditCategory(CategoryValue category) => CategoryValue = category;

        public static Subcategory Create(string name, CategoryValue category) 
            => new Subcategory(new SubcategoryId(), new SubcategoryName(name), category);

        public static Subcategory Create(Guid id, string name, CategoryValue category)
           => new Subcategory(new SubcategoryId(id), new SubcategoryName(name), category);

        private Subcategory(SubcategoryId subcategoryId, SubcategoryName name, CategoryValue category) : base(subcategoryId)
        {
            Name = name;
            Category = category;
            Concepts = new HashSet<Concept>();
        }

        public ICollection<Concept> Concepts { get; private set; }
        public int TotalConcepts => Concepts.Count();
        public bool HasConcepts => Concepts.Any();

        public override string ToString() => Name.ToString();
    }
}
