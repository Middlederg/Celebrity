using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Celebrity.Domain;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace Celebrity.Data
{
    public class ConceptRepository : IConceptRepository
    {
        private readonly CelebrityContext context;

        public ConceptRepository(CelebrityContext context)
        {
            this.context = context;
        }

        public async Task<Concept> GetConcept(ConceptId id)
        {
            var concept = await context.Concepts
               .Include(x => x.Subcategories)
               .AsNoTracking()
               .FirstOrDefaultAsync(x => x.Id == id);

            return concept;
        }

        public async Task<IEnumerable<Concept>> GetAll()
        {
            var list = await context.Concepts
                .Include(x => x.Subcategories)
                .AsNoTracking()
                .ToListAsync();

            return list;
        }

        public async Task<IEnumerable<Concept>> GetAll(IEnumerable<ConceptId> idCollection)
        {
            var list = await context.Concepts
                  .Where(x => idCollection.Any(id => id == x.Id))
                  .Include(x => x.Subcategories)
                  .ToListAsync();

            return list;
        }

        public async Task<IEnumerable<Concept>> GetAllFromCategory(Shared.CategoryValue value)
        {
            var list = await context.Concepts
               .WithCategory(value)
               .Include(x => x.Subcategories)
               .AsNoTracking()
               .ToListAsync();

            return list;
        }

        public async Task<IEnumerable<Concept>> GetAllFromSubcategory(SubcategoryId id)
        {
            var list = await context.Concepts
               .WithSubcategory(id)
               .Include(x => x.Subcategories)
               .AsNoTracking()
               .ToListAsync();

            return list;
        }

        public async Task<IEnumerable<Concept>> GetFromCriteria(Shared.GameCreationCriteria criteria)
        {
            var list = await context.Concepts
              .WithCriteria(criteria)
              .Include(x => x.Subcategories)
              .AsNoTracking()
              .ToListAsync();

            return list;
        }

        public void AddConcept(Concept concept)
        {
            context.Concepts.Add(concept);
        }

        public void Update(Concept concept)
        {
           context.Entry(concept).State = EntityState.Modified;
        }

        public void DeleteConcept(Concept concept)
        {
           context.Concepts.Remove(concept);
        }

        public void UpdateSubcategories(ConceptId conceptId, IEnumerable<Guid> subcategories)
        {
            var commandtext = $"DELETE FROM ConceptSubcategory where conceptsId = @ConceptId";
            var conceptParameter = new SqliteParameter("@ConceptId", conceptId.ToString().ToUpper());
            context.Database.ExecuteSqlRaw(commandtext, conceptParameter);

            commandtext = $"INSERT INTO ConceptSubcategory (ConceptsId, SubcategoriesId) VALUES (@ConceptId, @SubcategoryId)";
            foreach (var subcategoryId in subcategories)
            {
                var subcategoryParameter = new SqliteParameter("@SubcategoryId", subcategoryId.ToString().ToUpper());
                context.Database.ExecuteSqlRaw(commandtext, conceptParameter, subcategoryParameter);
            }
            context.SaveChanges();
        }
    }
}
