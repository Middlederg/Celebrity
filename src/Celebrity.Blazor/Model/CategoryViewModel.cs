using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Blazor
{
    public class CategoryViewModel
    {
        private readonly string name;
        public string Id { get; }

        public List<BaseOption<SubcategoryObject>> Subcategories { get; set; }
        public bool AllSelected => Subcategories.TrueForAll(x => x.IsChecked);
        public void SelectAll() => MarkAllAs(selected:true);
        public void UnselectAll() => MarkAllAs(selected:false);
        private void MarkAllAs(bool selected)
        {
            foreach (var subcategory in Subcategories)
            {
                subcategory.IsChecked = selected;
            }
        }

        public bool Visible { get; set; }

        public CategoryViewModel(Category category)
        {
            name = category.ToString();
            Id = category.Id.ToString();
            Subcategories = category.GetSubcategories()
                .Select(x => new BaseOption<SubcategoryObject>(x, false))
                .ToList();
            Visible = true;
        }

        public override string ToString() => name;
    }
}
