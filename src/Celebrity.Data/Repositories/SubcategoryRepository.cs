using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using Celebrity.Domain;

namespace Celebrity.Data
{
    public class SubcategoryRepository : ISubcategoryRepository
    {
        private readonly CelebrityContext context;

        public SubcategoryRepository(CelebrityContext context)
        {
            this.context = context;
        }

        public void Add(Subcategory subcategory)
        {
            context.Subcategories.Add(subcategory);
        }

        public void Delete(Subcategory subcategory)
        {

            context.Subcategories.Remove(subcategory);

        }

        public void Save(Subcategory subcategory)
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
