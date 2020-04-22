using System.Collections.Generic;

namespace Celebrity
{
    public class Difficulty : ValueObject
    {
        private static readonly IDictionary<DifficultyValue, Difficulty> statuses = new Dictionary<DifficultyValue, Difficulty>();

        public static readonly Difficulty NotDefined = new Difficulty(DifficultyValue.NotDefined, nameof(NotDefined));
        public static readonly Difficulty Easy = new Difficulty(DifficultyValue.Easy, nameof(Easy));
        public static readonly Difficulty Intermediate = new Difficulty(DifficultyValue.Intermediate, nameof(Intermediate));
        public static readonly Difficulty Hard = new Difficulty(DifficultyValue.Hard, nameof(Hard));
        public static Difficulty GetValue(DifficultyValue stars)
        {
            if (statuses.TryGetValue(stars, out Difficulty result))
            {
                return result;
            }
            return NotDefined;
        }

        private Difficulty(DifficultyValue stars, string name)
        {
            this.Value = stars;
            this.name = name;
            statuses.Add(stars, this);
        }

        public DifficultyValue Value { get; }
        private readonly string name;

        public override string ToString() => name;

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }

        public static IReadOnlyCollection<Difficulty> Values => statuses.Values as IReadOnlyCollection<Difficulty>;
    }
}
