using System;

namespace Celebrity.Shared
{
    public static class SubcategoryEndpoints
    {
        public const string Base = "api/subcategories";

        public static string GetSubcategories() => Base;
        public static string GetSubcategory(Guid subcategoryId) => $"{Base}/{subcategoryId}";

        public static string PostCreate => Base;
        public static string PatchUpdate(Guid subcategoryId) => $"{Base}/{subcategoryId}";

        public static string DeleteSubcategory(Guid subcategoryId) => $"{Base}/{subcategoryId}";
    }
}
