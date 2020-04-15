using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Blazor
{
    public class CategoriesViewModel
    {
        public string SearchText { get; set; }
        public List<CategoryViewModel> Categories { get; }

        public CategoriesViewModel(IEnumerable<Category> categories)
        {
            Categories = categories
                .Select(category => new CategoryViewModel(category))
                .ToList();
        }

        public void Search()
        {
            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                MakeAllCategories(visible: false);
                foreach (var item in Categories.Where(x => x.ToString().Contains(SearchText) ||
                     x.Subcategories.Any(s => s.Entity.ToString().Contains(SearchText))))
                {
                    item.Visible = true;
                }
            }
            else MakeAllCategories(visible: true);
        }

        private void MakeAllCategories(bool visible)
        {
            foreach (var item in Categories)
            {
                item.Visible = visible;
            }
        }

        public void SelectAll()
        {
            foreach (var category in Categories)
            {
                category.SelectAll();
            }
        }

        public void UnselectAll()
        {
            foreach (var category in Categories)
            {
                category.UnselectAll();
            }
        }
    }
}
