using System.Collections.Generic;

namespace Celebrity
{
    public class IpAddress : ValueObject
    {
        public static IpAddress Undefined => new IpAddress(UndefinedIpAddressValue);

        private const string UndefinedIpAddressValue = "-";
        public const int MaxLength = 100;

        protected readonly string value;

        public IpAddress(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                value = UndefinedIpAddressValue;
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
