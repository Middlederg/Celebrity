using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Blazor
{
    public class SubcategoriesViewModel
    {
        public string SearchText { get; set; }
        public List<SubcategoryViewModel> Subcategories { get; set; }
        public string ErrorMessage => string.Join(" - ", Subcategories.
            Where(x => !string.IsNullOrWhiteSpace(x.ErrorMessage))
            .Select(x => x.ErrorMessage));

        public SubcategoriesViewModel(IEnumerable<Subcategory> subcategories)
        {
            Subcategories = subcategories
               .Select(subcategory => new SubcategoryViewModel(subcategory))
               .ToList();
        }

        public void Search()
        {
            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                MakeAllCategories(visible: false);
                foreach (var item in Subcategories.Where(x => x.Name.Equals(SearchText) ||
                     x.Category.Equals(SearchText)))
                {
                    item.Visible = true;
                }
            }
            else MakeAllCategories(visible: true);
        }

        private void MakeAllCategories(bool visible)
        {
            foreach (var item in Subcategories)
            {
                item.Visible = visible;
            }
        }

        public IEnumerable<SubcategoryId> GetDeleted()
        {
            return Subcategories
             .Where(subcategory =>  subcategory.Deleted)
             .Select(x => new SubcategoryId(x.Id))
             .ToList();
        }

        public IEnumerable<Subcategory> GetModified()
        {
            return Subcategories
             .Where(subcategory => subcategory.Deleted)
             .Select(x => Subcategory.Create(new SubcategoryId(x.Id), x.Name, x.Category))
             .ToList();
        }

        public bool HasChanges()
        {
            return GetDeleted().Any() || GetModified().Any();
        }
    }
}
