using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Celebrity.Domain;

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
            
            return ((Shared.CategoryValue[])Enum.GetValues(typeof(Shared.CategoryValue))).Select(value =>
            {
                var subcategoriesInCategory = subcategories
                    .Where(x => x.Category == value)
                    .Select(x => new BaseObject(x.Id, x.Name.ToString()))
                    .ToArray();

                return new Category(value, subcategoriesInCategory);
            });
        }

        public async Task<Category> GetCategory(Shared.CategoryValue value)
        {
            var subcategories = await context
               .Subcategories
               .Where(x => x.Category == value)
               .Select(x => new BaseObject(x.Id, x.Name.ToString()))
               .ToListAsync();

            return new Category(value, subcategories.ToArray());
        }
    }
}
