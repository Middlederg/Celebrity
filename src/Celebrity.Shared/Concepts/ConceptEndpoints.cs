using System;

namespace Celebrity.Shared
{
    public static class ConceptEndpoints
    {
        public const string Base = "api/concepts";

        public static string GetConcept(Guid conceptId) => $"{Base}/{conceptId}";

        public static string PostCreateListInSubcategory(Guid subcategoryId) => $"{Base}/{subcategoryId}";
        public static string PatchUpdate(Guid conceptId) => $"{Base}/{conceptId}";

        public static string DeleteSubcategory(Guid conceptId) => $"{Base}/{conceptId}";
    }
}