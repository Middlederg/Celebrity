using System.Collections.Generic;

namespace Celebrity.GamingContext
{
    public class UserAgent : ValueObject
    {
        public static UserAgent Undefined => new UserAgent(UndefinedUserAgentValue);
        public const string UndefinedUserAgentValue = "-";
        public const int MaxLength = 250;

        protected readonly string value;

        public UserAgent(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                value = UndefinedUserAgentValue;
            }

            if (value.Length > MaxLength)
            {
                value = value.Substring(0, MaxLength);
            }
            this.value = value;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }

        public override string ToString() => value;
    }
}
