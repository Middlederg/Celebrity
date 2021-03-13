using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public class GameCreationCriteriaBuilder
    {
        private int totalConcepts;
        public GameCreationCriteriaBuilder WithNumberOfConcepts(int number)
        {
            totalConcepts = number;
            return this;
        }

        private int totalRounds;
        public GameCreationCriteriaBuilder WithNumberOfRounds(int number)
        {
            totalRounds = number;
            return this;
        }

        private bool easy;
        private bool intermediate;
        private bool hard;
        public GameCreationCriteriaBuilder WithDifficulties(List<BaseOption<Difficulty>> difficulties)
        {
            easy = difficulties.Any(x => x.Entity.Equals(Difficulty.Easy) && x.IsChecked);
            intermediate = difficulties.Any(x => x.Entity.Equals(Difficulty.Intermediate) && x.IsChecked);
            hard = difficulties.Any(x => x.Entity.Equals(Difficulty.Hard) && x.IsChecked);
            return this;
        }

        private readonly List<Guid> subcategoriesToInclude;
        public GameCreationCriteriaBuilder WithSubcategories(params SubcategoryId[] subcategories)
        {
            subcategoriesToInclude.AddRange(subcategories.Select(x => (Guid)x));
            return this;
        }

        private readonly List<Team> teams;
        public GameCreationCriteriaBuilder WithTeams(params Team[] teams)
        {
            this.teams.AddRange(teams);
            return this;
        }

        public GameCreationCriteriaBuilder()
        {
            teams = new List<Team>();
            subcategoriesToInclude = new List<Guid>();
        }

        public GameCreationCriteria Build()
        {
            return new GameCreationCriteria(totalConcepts, totalRounds, easy, intermediate, hard, subcategoriesToInclude.ToArray(), teams.ToArray());
        }
    }
}
