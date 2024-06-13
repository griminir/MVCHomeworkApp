using System.CodeDom;
using System.ComponentModel.DataAnnotations;

namespace MVCHomework.Models
{
    public class PersonModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Active User")]
        public bool IsActive { get; set; }
    }
}
