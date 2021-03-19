using System.Linq;

namespace Celebrity.Domain
{
    public static class CategoryMapper
    {
        public static Shared.Category ToDto(this Category category)
        {
            return new Shared.Category()
            {
                Value = category.Value,
                Subcategories = category.Subcategories.Select(x => new Shared.BaseObject()
                {
                    Id = x.Id,
                    Name = x.ToString()
                }),
            };
        }
    }
}
