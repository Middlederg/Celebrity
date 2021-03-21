using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using Celebrity.Domain;
using System.Linq;

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
            context.Subcategories.Add(subcategory);
        }

        public void DeleteCategory(Subcategory subcategory)
        {

            context.Subcategories.Remove(subcategory);

        }

        public void EditSubcategory(Subcategory subcategory)
        {
            context.Entry(subcategory).State = EntityState.Modified;

        }

        public async Task<IEnumerable<Subcategory>> GetSubcategories()
        {
            var list = await context
                .Subcategories
                .Include(x => x.Concepts)
                .ToListAsync();

            return list;
        }

        public async Task<Subcategory> GetSubcategory(SubcategoryId id)
        {
            var subcategory = await context
             .Subcategories
             .Include(x => x.Concepts)
             .FirstOrDefaultAsync(x => x.Id == id);

            return subcategory;
        }
    }
}
