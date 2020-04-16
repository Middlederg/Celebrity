using Celebrity.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace Celebrity.Data
{
    public class SubcategoryRepository : ISubcategoryRepository
    {
        private readonly CelebrityContext context;

        public SubcategoryRepository(CelebrityContext context)
        {
            this.context = context;
        }

        public void AddSubcategory(Subcategory subcategory)
        {
            var subcategories = new Subcategories()
            {
                Id = subcategory.Id,
                Category = subcategory.Category,
                Name = subcategory.ToString()
            };
            context.Subcategories.Add(subcategories);
        }

        public async Task DeleteCategory(Subcategory subcategory)
        {
            var subcategories = await context.Subcategories.FindAsync((Guid)subcategory.Id);
            if (subcategories != null)
            {
                context.Subcategories.Remove(subcategories);
            }
        }

        public async Task EditSubcategoryName(Subcategory subcategory)
        {
            var subcategories = await context.Subcategories.FindAsync((Guid)subcategory.Id);
            if (subcategories != null)
            {
                subcategories.Name = subcategory.ToString();
                context.Entry(subcategories).State = EntityState.Modified;
            }
        }
    }
}
