using System;

namespace Celebrity.Web
{
    public class TagViewModel
    {
        public Guid SubcategoryId { get; set; }
        public string Name { get; set; }

        public TagViewModel(Guid subcategoryId, string name)
        {
            SubcategoryId = subcategoryId;
            Name = name;
        }

        public SubcategoryObject CreateSubcategory() => new SubcategoryObject(SubcategoryId, Name);
    }
}
