using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Blazor
{
    public class ConceptsViewModel
    {
        public string SearchText { get; set; }
        public List<ConceptViewModel> Concepts { get; set; }
        public string ErrorMessage => string.Join(" - ", Concepts.
            Where(x => !string.IsNullOrWhiteSpace(x.ErrorMessage))
            .Select(x => x.ErrorMessage));

        public ConceptsViewModel(IEnumerable<Concept> concepts)
        {
            Concepts = concepts
               .Select(concept => new ConceptViewModel(concept))
               .ToList();
        }

        public void Search()
        {
            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                MakeAllCategories(visible: false);
                foreach (var item in Concepts.Where(x => x.Name.Equals(SearchText)))
                {
                    item.Visible = true;
                }
            }
            else MakeAllCategories(visible: true);
        }

        private void MakeAllCategories(bool visible)
        {
            foreach (var item in Concepts)
            {
                item.Visible = visible;
            }
        }

        public IEnumerable<ConceptId> GetDeleted()
        {
            return Concepts
             .Where(concept => concept.Deleted)
             .Select(x => x.GetId())
             .ToList();
        }

        public IEnumerable<Concept> GetModified()
        {
            return Concepts
             .Where(concept => concept.Deleted)
             .Select(x => x.CreateConcept())
             .ToList();
        }

        public bool HasChanges()
        {
            return GetDeleted().Any() || GetModified().Any();
        }
    }
}
