using System.ComponentModel.DataAnnotations;

namespace Exercise27.ViewModels;
class CustomerContactVM
{
  [Required(ErrorMessage = "Full Name is required.")]
  [MinLength(3, ErrorMessage = "Full Name must be at least 3 characters long.")]
  public string FullName { get; set; }

  [Required(ErrorMessage = "Email is required.")]
  [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
  public string Email { get; set; }

  [Required(ErrorMessage = "Phone Number is required.")]
  [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits.")]
  public string PhoneNumber { get; set; }

  [Required(ErrorMessage = "Please select a course.")]
  public string SelectedCourse { get; set; }

  [Required(ErrorMessage = "Please select a study mode.")]
  public string StudyMode { get; set; }

  [Required(ErrorMessage = "Preferred start date is required.")]
  public DateTime? PreferredStartDate { get; set; }

  public string Comments { get; set; }

  [Required(ErrorMessage = "You must agree to the terms and conditions.")]
  public bool AgreeToTerms { get; set; }
}