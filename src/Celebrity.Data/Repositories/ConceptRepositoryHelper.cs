using System.Collections.Generic;
using System;
using System.Linq;

namespace Celebrity.Data
{
    public static class ConceptRepositoryHelper
    {
        public static IQueryable<Concepts> WithCriteria(this IQueryable<Concepts> list, Shared.GameCreationCriteria criteria)
        {
            return list
                .IncludeEasy(criteria.IncludeEasy)
                .IncludeIntermediate(criteria.IncludeIntermediate)
                .IncludeHard(criteria.IncludeHard)
                .WithSubcategory(criteria.SubcategoriesToInclude);
        }

        public static IQueryable<Concepts> IncludeEasy(this IQueryable<Concepts> list, bool includeEasy)
        {
            if (includeEasy)
            {
                return list.Where(x => x.Difficulty == Difficulty.Easy);
            }
            return list;
        }

        public static IQueryable<Concepts> IncludeIntermediate(this IQueryable<Concepts> list, bool includeIntermediate)
        {
            if (includeIntermediate)
            {
                return list.Where(x => x.Difficulty == Difficulty.Intermediate);
            }
            return list;
        }

        public static IQueryable<Concepts> IncludeHard(this IQueryable<Concepts> list, bool includeHard)
        {
            if (includeHard)
            {
                return list.Where(x => x.Difficulty == Difficulty.Hard);
            }
            return list;
        }

        public static IQueryable<Concepts> WithSubcategory(this IQueryable<Concepts> list, params Guid[] subcategories)
        {
            if (subcategories.Any())
            {
                return list.Where(x => x.SubcategoriesInconcepts.Any(x => subcategories.Contains(x.SubcategoryId)));
            }
            return list;
        }
    }
}
