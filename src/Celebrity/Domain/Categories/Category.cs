using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public class Category : Identity<CategoryId>
    {
        private readonly CategoryName name;
        public void EditName(string newName) => new CategoryName(newName);

        public static Category FromDataBase(Guid id, string name, params SubcategoryObject[] subcategories)
        {
            var category = new Category(new CategoryId(id), new CategoryName(name));
            foreach (var subcategory in subcategories)
            {
                category.AddSubcategory(subcategory);
            }
            return category;
        }

        public static Category Create(string name) => new Category(new CategoryId(), new CategoryName(name));

        private Category(CategoryId categoryId, CategoryName name) : base(categoryId)
        {
            this.name = name;
            categories = new List<SubcategoryObject>();
        }

        private readonly List<SubcategoryObject> categories;
        public void AddSubcategory(SubcategoryObject subcategory) => categories.Add(subcategory);
        public IEnumerable<SubcategoryObject> GetSubcategories() => categories.ToList();
        public bool HasSubcategories => categories.Any();

        public override string ToString() => name.ToString();
    }
}
