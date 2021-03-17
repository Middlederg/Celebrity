namespace Celebrity.Domain
{
    public static class CategoryMapper
    {
        public static Shared.Category ToDto(this Category category)
        {
            return new Shared.Category()
            {
                Value = category.GetSubcategories
            };
        }
    }
}
