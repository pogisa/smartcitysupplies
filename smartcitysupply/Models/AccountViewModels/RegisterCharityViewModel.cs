using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace smartcitysupply.Models.AccountViewModels
{
    public class RegisterCharityViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Name of Charity")]
        public string CharityName { get; set; }

        [Required]
        [RegularExpression(@"\d{2}-\d{7}", ErrorMessage = "The {0} must be a number with nine (9) digits in the format 12-3456789")]
        [DataType(DataType.Text)]
        [Display(Name = "Tax EIN")]
        public string Ein { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Address")]
        public string AddressLine1 { get; set; }

        [StringLength(100, ErrorMessage = "The {0} must be at max {1} characters long.")]
        [DataType(DataType.Text)]
        public string AddressLine2 { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "The {0} must be exactly {1} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [RegularExpression(@"\d{5}", ErrorMessage = "The {0} must be a number with 5 digits.")]
        [DataType(DataType.Text)]
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }

        [Required]
        [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "The {0} must be in the format 123-456-7890.")]
        [DataType(DataType.Text)]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
