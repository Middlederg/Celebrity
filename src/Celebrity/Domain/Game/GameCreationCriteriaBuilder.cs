using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Repositories
{
    public class GameCreationCriteriaBuilder
    {
        private int totalConcepts;
        public GameCreationCriteriaBuilder SetNumberOfConcepts(int number)
        {
            totalConcepts = number;
            return this;
        }

        private int totalRounds;
        public GameCreationCriteriaBuilder SetNumberOfRounds(int number)
        {
            totalRounds = number;
            return this;
        }

        private bool easy;
        public GameCreationCriteriaBuilder IncludeEasyOnes()
        {
            easy = true;
            return this;
        }

        private bool intermediate;
        public GameCreationCriteriaBuilder IncludeIntermediateOnes()
        {
            intermediate = true;
            return this;
        }

        private bool hard;
        public GameCreationCriteriaBuilder IncludeHardOnes()
        {
            hard = true;
            return this;
        }


        private readonly List<Guid> subcategoriesToInclude;
        public GameCreationCriteriaBuilder AddSubCategories(params SubcategoryId[] subcategories)
        {
            subcategoriesToInclude.AddRange(subcategories.Select(x => (Guid)x));
            return this;
        }

        private readonly List<Team> teams;
        public GameCreationCriteriaBuilder AddTeams(params Team[] teams)
        {
            this.teams.AddRange(teams);
            return this;
        }

        public GameCreationCriteriaBuilder()
        {
            subcategoriesToInclude = new List<Guid>();
        }

        public GameCreationCriteria Build()
        {
            return new GameCreationCriteria(totalConcepts, totalRounds, easy, intermediate, hard, subcategoriesToInclude, teams);
        }
    }
}
