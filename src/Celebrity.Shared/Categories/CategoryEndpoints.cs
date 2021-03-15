namespace Celebrity.Shared
{
    public static class CategoryEndpoints
    {
        public const string Base = "api/categories";

        public static string GetCategories() => Base;
        public static string GetCategory(int categoryId) => $"{Base}/{categoryId}";
    }
}
