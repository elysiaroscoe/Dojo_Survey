using System.ComponentModel.DataAnnotations;

namespace Dojo_Survey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(3)]
        // Convert the way it displays on model [Display(Name = "Your Name:")]
        public string Name { get; set; }
        [Required]
        [MinLength(2)]
        public string Location { get; set; }
        [Required]
        [MinLength(1)]
        public string Language { get; set; }
        [Display(Name = "Comment (Optional)")]
        [MinLength(20)]
        public string Comment { get; set; }

        public Survey(){}

        public Survey(string name, string location, string language, string comment)
        {
            Name = name;
            Location = location;
            Language = language;
            Comment = comment;
        }
    }

}