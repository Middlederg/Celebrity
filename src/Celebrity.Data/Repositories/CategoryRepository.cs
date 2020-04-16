using Celebrity.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Celebrity.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CelebrityContext context;

        public CategoryRepository(CelebrityContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            var subcategories = await context
                .Subcategories
                .ToListAsync();
            
            return ((CategoryValue[])Enum.GetValues(typeof(CategoryValue))).Select(value =>
            {
                var subcategoriesInCategory = subcategories
                    .Where(x => x.Category == value)
                    .Select(x => new SubcategoryObject(x.Id, x.Name))
                    .ToArray();

                return new Category(value, subcategoriesInCategory);
            });
        }

        public async Task<Category> GetCategory(CategoryValue value)
        {
            var subcategories = await context
               .Subcategories
               .Where(x => x.Category == value)
               .Select(x => new SubcategoryObject(x.Id, x.Name))
               .ToListAsync();
            return new Category(value, subcategories.ToArray());
        }
    }
}
