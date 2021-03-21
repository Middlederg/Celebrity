using System.Collections.Generic;
using System;
using System.Linq;
using Celebrity.Domain;

namespace Celebrity.Data
{
    public static class ConceptRepositoryHelper
    {
        public static IQueryable<Concept> WithCriteria(this IQueryable<Concept> list, Shared.GameCreationCriteria criteria)
        {
            return list
                .IncludeEasy(criteria.IncludeEasy)
                .IncludeIntermediate(criteria.IncludeIntermediate)
                .IncludeHard(criteria.IncludeHard)
                .WithSubcategory(criteria.SubcategoriesToInclude.Select(x => new SubcategoryId()).ToArray());
        }

        public static IQueryable<Concept> IncludeEasy(this IQueryable<Concept> list, bool includeEasy)
        {
            if (includeEasy)
            {
                return list.Where(x => x.Difficulty == Difficulty.Easy);
            }
            return list;
        }

        public static IQueryable<Concept> IncludeIntermediate(this IQueryable<Concept> list, bool includeIntermediate)
        {
            if (includeIntermediate)
            {
                return list.Where(x => x.Difficulty == Difficulty.Intermediate);
            }
            return list;
        }

        public static IQueryable<Concept> IncludeHard(this IQueryable<Concept> list, bool includeHard)
        {
            if (includeHard)
            {
                return list.Where(x => x.Difficulty == Difficulty.Hard);
            }
            return list;
        }

        public static IQueryable<Concept> WithSubcategory(this IQueryable<Concept> list, params SubcategoryId[] subcategories)
        {
            if (subcategories.Any())
            {
                return list.Where(x => x.Subcategories.Any(x => subcategories.Contains(x.Id)));
            }
            return list;
        }

        public static IQueryable<Concept> WithCategory(this IQueryable<Concept> list, Shared.CategoryValue category)
        {
           return list.Where(x => x.Subcategories.Any(x => x.Category == category));

        }
    }
}
