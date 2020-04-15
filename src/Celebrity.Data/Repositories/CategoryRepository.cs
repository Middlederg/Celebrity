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

        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void EditCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            var categories = await context.Categories.Include(x => x.Subcategories).ToListAsync();

            return categories.Select(x =>
            {
                return Category.FromDataBase(x.Id, x.Name, x.Subcategories
                    .Select(sc => new SubcategoryObject(sc.Id, sc.Name))
                    .ToArray());
            });
        }

        public Task<Category> GetCategory(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
