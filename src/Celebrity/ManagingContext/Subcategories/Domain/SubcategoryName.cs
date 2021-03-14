namespace Celebrity.ManagingContext
{
    public class SubcategoryName : StringValueObject
    {
        public const int MaxLength = 100;
        public SubcategoryName(string value) : base(value, MaxLength) { }
    }
}
