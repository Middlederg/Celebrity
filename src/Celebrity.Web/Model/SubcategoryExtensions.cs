using Celebrity.Shared;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Web
{
    public static class SubcategoryExtensions
    {
        public static IEnumerable<Subcategory> Search(this IEnumerable<Subcategory> items, string text)
        {
            var result = items
                .Where(x =>
                    string.IsNullOrWhiteSpace(text) ||
                    x.Name.Contains(text) ||
                    x.Category.ToString().Contains(text))
                .ToList();
            return result;
        }
    }
}
