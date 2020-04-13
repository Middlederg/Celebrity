namespace Celebrity
{
    public class TeamName : StringValueObject
    {
        public const int MaxLength = 25;
        public TeamName(string value) : base(value, MaxLength) { }
    }
}
