namespace Celebrity.ManagingContext
{
    public class CategoryName : StringValueObject
    {
        public const int MaxLength = 100;
        public CategoryName(string value) : base(value, MaxLength) { }
    }
}
