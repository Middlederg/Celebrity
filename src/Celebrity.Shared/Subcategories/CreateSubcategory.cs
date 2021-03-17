using System.ComponentModel.DataAnnotations;

namespace Celebrity.Shared
{
    public class CreateSubcategory
    {
        [Required]
        [StringLength(Subcategory.NameMaxLength, ErrorMessage = "Name max length is {1} characters long")]
        public string Name { get; set; }

        public CategoryValue Category { get; set; }
    }
}
