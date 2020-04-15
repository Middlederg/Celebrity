using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public static class DeckFactory
    {
        public static Deck Create(IEnumerable<Concept> concepts) => new Deck(concepts);
        public static Deck Create(IEnumerable<BaseOption<Concept>> concepts)
        {
            var listOfConcepts = concepts.Select(option => {
                if (option.IsChecked)
                {
                    option.Entity.Guess();
                }
                return option.Entity;
            });
            return new Deck(listOfConcepts.ToList());
        }
    }
}
