using System.ComponentModel.DataAnnotations;

namespace Exercise27.ViewModels;
class UserRegiserVM
{
  [Required(ErrorMessage = "FullName is required")]
  [MinLength(3, ErrorMessage = "FullName must be at least 3 characters")]
  public string FullName { get; set; }

  [Required(ErrorMessage = "Email is required")]
  [EmailAddress(ErrorMessage = "Invalid email format.")]
  [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email is not valid.")]
  public string Email { get; set; }

  [Required(ErrorMessage = "Phone Number is required.")]
  [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits.")]
  public string PhoneNumber { get; set; }

  [Required(ErrorMessage = "Please select a course.")]
  public string SelectedCourse {get; set;}

  [Required(ErrorMessage ="Please select a study mode.")]
  public string StudyMode {get; set;}

  [Required(ErrorMessage = "Preferred start date is required.")]
  public DateTime? PreferredStartDate {get; set;}

  public string Comments{get; set;}

  [Required(ErrorMessage = "You must agree to the terms and conditions.")]
  public bool AgreeToTerms {get; set;}
}