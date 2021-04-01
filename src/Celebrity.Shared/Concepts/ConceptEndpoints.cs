using System;

namespace Celebrity.Shared
{
    public static class ConceptEndpoints
    {
        public const string Base = "api/concepts";

        public static string GetConcept(Guid conceptId) => $"{Base}/{conceptId}";
        public static string GetAllFromCategory(CategoryValue category) => $"api/categories/{(int)category}/concepts";
        public static string GetAllFromSubcategory(Guid subcategoryId) => $"api/subcategories/{subcategoryId}/concepts";

        public static string PostCreateList => Base;
        public static string PatchUpdateList => Base;
        public static string PutSubcategoriesFromConcept(Guid conceptId) => $"api/concepts/{conceptId}/subcategories";

        public static string DeleteConcept(Guid conceptId) => $"{Base}/{conceptId}";
    }
}