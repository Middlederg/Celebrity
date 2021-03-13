using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Web
{
    public class CategoryViewModel
    {
        private readonly string name;

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
            Subcategories = category.GetSubcategories()
                .Select(x => new BaseOption<SubcategoryObject>(x, false))
                .ToList();
            Visible = true;
        }

        public IEnumerable<SubcategoryId> GetSelectedIds => Subcategories
            .Where(x => x.IsChecked)
            .Select(x => x.Entity.Id);

        public override string ToString() => name;
    }
}
