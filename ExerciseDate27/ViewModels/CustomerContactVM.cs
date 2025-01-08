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

  [Required(ErrorMessage = "Address is required.")]
  public string Address { get; set; }

  [Required(ErrorMessage = "Message must be at lease 10 characters long.")]
  [MinLength(10, ErrorMessage = "Message must be at least 10 characters long.")]
  [MaxLength(20, ErrorMessage = "Message must be at most 20 characters")]
  public string Message { get; set; }


  [Required(ErrorMessage = "Please choose service")]
  public string SelectedService { get; set; }

  [Required()]
  public bool AgreeToTerms { get; set; }

}