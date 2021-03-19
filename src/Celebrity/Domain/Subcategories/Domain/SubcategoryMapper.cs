using System.Linq;

namespace Celebrity.Domain
{
    public static class SubcategoryMapper
    {
        public static Shared.Subcategory ToDto(this Subcategory subcategory)
        {
            return new Shared.Subcategory()
            {
                Id = subcategory.Id,
                Category = subcategory.Category ,
                Concepts = subcategory.Concepts.Select(x => new Shared.BaseObject()
                {
                    Id = x.Id,
                    Name = x.ToString()
                }),
                Name = subcategory.ToString()
            };
        }
    }
}
