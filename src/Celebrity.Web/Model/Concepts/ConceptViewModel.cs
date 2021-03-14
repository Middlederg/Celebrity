using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Web
{
    public class ConceptViewModel
    {
        public Guid Id { get; }
        public ConceptId GetId() => new ConceptId(Id);

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                Modify();
            }
        }

        private Difficulty stars;
        public Difficulty Stars 
        {
            get => stars;
            set
            {
                stars = value;
                Modify();
            }
        }

        private ConceptType conceptType;
        public ConceptType ConceptType
        {
            get => conceptType;
            set
            {
                conceptType = value;
                Modify();
            }
        }

        public List<TagViewModel> tags;
        public List<TagViewModel> Tags 
        {
            get => tags;
            set
            {
                tags = value;
                Modify();
            }
        }

        public bool Modified { get; private set; }
        private void Modify()
        {
            try
            {
                CreateConcept();
                Deleted = false;
                Modified = true;
                ErrorMessage = "";
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        public bool Deleted { get; private set; }
        public void MarkToDelete()
        {
            Deleted = true;
            Modified = false;
            Visible = false;
            ErrorMessage = "";
        }

        public bool Visible { get; set; }

        public string ErrorMessage { get; private set; }

        public ConceptViewModel(Concept concept)
        {
            Id = concept.Id;
            Name = concept.ToString();
            Tags = concept.Subcategories
                .Select(x => new TagViewModel(x.Id, Name = x.ToString()))
                .ToList();
            Modified = false;
            Deleted = false;
            Visible = true;
            ErrorMessage = "";
        }

        public Concept CreateConcept()
        {
            var concept = Concept.Create(new ConceptId(), Name, (int)Stars, ConceptType, 
                Tags.Select(x => x.CreateSubcategory()).ToArray());
            return concept;
        }
    }
}
