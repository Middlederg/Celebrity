using System;
using System.ComponentModel.DataAnnotations;

namespace Celebrity.Shared
{
    public class UpdateConcept
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(Concept.NameMaxLength, ErrorMessage = "Name max length is {1} characters long")]
        public string Name { get; set; }

        public Difficulty Difficulty { get; set; }

        public ConceptType Type { get; set; }
    }
}