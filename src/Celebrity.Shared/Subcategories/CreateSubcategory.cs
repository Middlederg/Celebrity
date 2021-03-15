using System.ComponentModel.DataAnnotations;

namespace Celebrity.Shared
{
    public class CreateSubcategory
    {
        [Required]
        [StringLength(35, ErrorMessage = "Name max length is {1} characters long")]
        public string Name { get; set; }

        public CategoryValue Category { get; set; }
    }
}
