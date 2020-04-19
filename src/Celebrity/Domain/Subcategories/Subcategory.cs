using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public class Subcategory : Identity<SubcategoryId>
    {
        private readonly SubcategoryName name;
        public void EditName(string newName) => new SubcategoryName(newName);

        public CategoryValue Category { get; }
        public bool IsChildOf(CategoryValue category) => this.Category == category;

        public static Subcategory Create(string name, CategoryValue category) 
            => new Subcategory(new SubcategoryId(), new SubcategoryName(name), category);

        public static Subcategory Create(Guid id, string name, CategoryValue category)
           => new Subcategory(new SubcategoryId(id), new SubcategoryName(name), category);

        private Subcategory(SubcategoryId subcategoryId, SubcategoryName name,  CategoryValue category) : base(subcategoryId)
        {
            this.name = name;
            this.Category = category;
            concepts = new List<ConceptObject>();
        }

        private readonly List<ConceptObject> concepts;
        public void AddConcept(ConceptObject subcategory) => concepts.Add(subcategory);
        public IEnumerable<ConceptObject> GetConcepts() => concepts.ToList();
        public int TotalConcepts => concepts.Count();
        public bool HasConcepts => concepts.Any();

        public override string ToString() => name.ToString();
    }
}
