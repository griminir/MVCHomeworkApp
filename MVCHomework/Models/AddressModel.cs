using System.ComponentModel.DataAnnotations;

namespace MVCHomework.Models
{
    public class AddressModel
    {
        [Required]
        [Display(Name ="Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        [StringLength(4, MinimumLength = 4)]
        public string ZipCode { get; set; }
    }
}
