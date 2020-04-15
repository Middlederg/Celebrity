using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public class Subcategory : Identity<SubcategoryId>
    {
        private readonly SubcategoryName name;
        public void EditName(string newName) => new SubcategoryName(newName);

        private readonly CategoryObject parent;
        public bool HasParent => parent != null;
        public string Parent => parent?.ToString() ?? "";
        public bool IsChildOf(CategoryId categoryId) => HasParent && parent.Is(categoryId);

        public bool IsCustomized { get; }

        public static Subcategory FromDataBase(Guid id, string name, bool isCustomized, Guid categoryId, string categoryName) 
            => new Subcategory(new SubcategoryId(id), new SubcategoryName(name), isCustomized, new CategoryObject(categoryId, categoryName));

        public static Subcategory Create(string name) => new Subcategory(new SubcategoryId(), new SubcategoryName(name), isCustomized:true, null);
        public static Subcategory Create(string name, CategoryObject category) => new Subcategory(new SubcategoryId(), new SubcategoryName(name), isCustomized: false, category);
        public static Subcategory CreateCustom(string name, CategoryObject category) => new Subcategory(new SubcategoryId(), new SubcategoryName(name), isCustomized: true, category);

        private Subcategory(SubcategoryId subcategoryId, SubcategoryName name, bool isCustomized, CategoryObject parent) : base(subcategoryId)
        {
            this.name = name;
            IsCustomized = isCustomized;
            this.parent = parent;
            concepts = new List<ConceptObject>();
        }

        private readonly List<ConceptObject> concepts;
        public void AddConcept(ConceptObject subcategory) => concepts.Add(subcategory);
        public IEnumerable<ConceptObject> GetConcepts() => concepts.ToList();

        public override string ToString() => name.ToString();
    }
}
