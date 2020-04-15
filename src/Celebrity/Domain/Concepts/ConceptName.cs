namespace Celebrity
{
    public class ConceptName : StringValueObject
    {
        public const int MaxLength = 200;
        public ConceptName(string value) : base(value, MaxLength) { }
    }
}
