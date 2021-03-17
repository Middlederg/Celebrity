namespace Celebrity.Domain
{
    public class SubcategoryName : StringValueObject
    {
        public const int MaxLength = 100;
        public SubcategoryName(string value) : base(value, Shared.Subcategory.NameMaxLength) { }
    }
}
