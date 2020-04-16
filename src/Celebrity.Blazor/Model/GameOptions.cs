using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Blazor
{
    public class GameOptionsViewModel
    {
        public int ConceptCount { get; set; }

        public int RoundCount { get; set; }

        public int Seconds { get; set; }

        public List<BaseOption<Difficulty>> DifficultiesList { get; }
        public BaseOption<Difficulty> GetValue(Difficulty difficulty)
        {
            return DifficultiesList.First(x => x.Entity == difficulty);
        }

        public GameOptionsViewModel()
        {
            ConceptCount = 40;
            RoundCount = 3;
            Seconds = 30;
            DifficultiesList = new List<BaseOption<Difficulty>>()
            {
                new BaseOption<Difficulty>(Difficulty.Easy, isChecked: true),
                new BaseOption<Difficulty>(Difficulty.Intermediate, isChecked: true),
                new BaseOption<Difficulty>(Difficulty.Hard, isChecked: false),
            };
        }
    }
}
