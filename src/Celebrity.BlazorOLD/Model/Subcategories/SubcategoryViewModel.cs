using System;

namespace Celebrity.Blazor
{
    public class SubcategoryViewModel
    {
        public Guid Id { get; set; }

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

        private CategoryValue category;
        public CategoryValue Category
        {
            get => category;
            set
            {
                category = value;
                Modify();
            }
        }
        public int TotalConcepts { get; set; }
        public string HasConceptsClass => TotalConcepts > 0 ? "disabled" : "";

        public bool Modified { get; private set; }
        public void Modify()
        {
            try
            {
                Subcategory.Create(Name, Category);
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

        public string ErrorMessage { get; set; }

        public SubcategoryViewModel(Subcategory subcategory)
        {
            Id = subcategory.Id;
            Name = subcategory.ToString();
            Category = subcategory.Category;
            TotalConcepts = subcategory.TotalConcepts;
            Modified = false;
            Deleted = false;
            Visible = true;
            ErrorMessage = "";
        }
    }
}
