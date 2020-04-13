using System.Collections.Generic;

namespace Celebrity.Repositories
{
    public class DeckSelectionCriteriaBuilder
    {
        private bool easy;
        public DeckSelectionCriteriaBuilder IncludeEasyOnes()
        {
            easy = true;
            return this;
        }

        private bool intermediate;
        public DeckSelectionCriteriaBuilder IncludeIntermediateOnes()
        {
            intermediate = true;
            return this;
        }

        private bool hard;
        public DeckSelectionCriteriaBuilder IncludeHardOnes()
        {
            hard = true;
            return this;
        }


        private List<SubcategoryId> subcategoriesToInclude;
        public DeckSelectionCriteriaBuilder AddSubCategories(params SubcategoryId[] subcategories)
        {
            subcategoriesToInclude.AddRange(subcategories);
            return this;
        }

        public DeckSelectionCriteriaBuilder()
        {
            subcategoriesToInclude = new List<SubcategoryId>();
        }

        public DeckSelectionCriteria Build(int maximun)
        {
            return new DeckSelectionCriteria(maximun, easy, intermediate, hard, subcategoriesToInclude);
        }
    }
}
