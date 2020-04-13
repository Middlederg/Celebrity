using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Blazor
{
    public class Difficulties
    {
        public List<BaseOption<Difficulty>> DifficultiesList { get; }
        public BaseOption<Difficulty> GetValue(Difficulty difficulty)
        {
            return DifficultiesList.First(x => x.Entity == difficulty);
        }

        public Difficulties()
        {
            DifficultiesList = new List<BaseOption<Difficulty>>()
            {
                new BaseOption<Difficulty>(Difficulty.Easy, isChecked: true),
                new BaseOption<Difficulty>(Difficulty.Intermediate, isChecked: true),
                new BaseOption<Difficulty>(Difficulty.Hard, isChecked: false),
            };
        }
    }
}
