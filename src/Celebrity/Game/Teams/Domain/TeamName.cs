namespace Celebrity.Domain
{
    public class TeamName : StringValueObject
    {
        public TeamName(string value) : base(value, Shared.Team.NameMaxLength) { }
    }
}
