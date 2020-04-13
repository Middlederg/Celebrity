using System.Collections.Generic;

namespace Celebrity
{
    public class StringValueObject : ValueObject
    {
        internal const int DefaultMaxLength = 100;

        protected readonly string value;

        public StringValueObject(string value, int maxLength = DefaultMaxLength)
        {
            Ensure.NotNullOrEmpty(value);
            Ensure.That(value.Length <= maxLength, $"value is {value.Length} and max length is {maxLength}");
            this.value = value;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }

        public override string ToString() => value;
    }
}
