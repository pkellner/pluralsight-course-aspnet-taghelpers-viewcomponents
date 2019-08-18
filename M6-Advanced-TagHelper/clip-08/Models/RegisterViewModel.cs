using System.ComponentModel.DataAnnotations;

namespace WebAppTagHelper.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [MaxLength(15)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
            MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required] public string CountryCode { get; set; }

        [Required] public bool SpecialMeal { get; set; }

        public RegisterAddress RegisterAddress { get; set; }
    }

    public class RegisterAddress
    {
        public string City { get; set; }

        [MaxLength(2)]
        [MinLength(2)]
        [Required]
        public string State { get; set; }

        [Phone] public string PhoneNumber { get; set; }
    }
}