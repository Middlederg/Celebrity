namespace Celebrity
{
    public class ConceptName : StringValueObject
    {
        public ConceptName(string value) : base(value, Shared.Concept.NameMaxLength) { }
    }
}
