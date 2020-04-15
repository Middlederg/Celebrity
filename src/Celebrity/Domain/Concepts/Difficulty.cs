using System.Collections.Generic;

namespace Celebrity
{
    public class Difficulty
    {
        private static readonly IDictionary<int, Difficulty> statuses = new Dictionary<int, Difficulty>();

        public static readonly Difficulty NotDefined = new Difficulty(0, nameof(NotDefined));
        public static readonly Difficulty Easy = new Difficulty(1, nameof(Easy));
        public static readonly Difficulty Intermediate = new Difficulty(2, nameof(Intermediate));
        public static readonly Difficulty Hard = new Difficulty(3, nameof(Hard));
        public static Difficulty GetValue(int stars)
        {
            if (statuses.TryGetValue(stars, out Difficulty result))
            {
                return result;
            }
            return NotDefined;
        }

        private Difficulty(int stars, string name)
        {
            this.stars = stars;
            this.name = name;
            statuses.Add(stars, this);
        }

        internal int stars;
        internal string name;

        public override string ToString() => name;

        public static IReadOnlyCollection<Difficulty> Values => statuses.Values as IReadOnlyCollection<Difficulty>;
    }
}
