using System.ComponentModel.DataAnnotations;

namespace HairHarmonySalon.ViewModel
{
	public class RegisterVM
	{
		[Required(ErrorMessage = "Username cannot be blank.")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Password cannot be blank.")]
	public string Password { get; set; }
		[Required(ErrorMessage = "Confirm Password cannot be blank.")]
		[Compare("Password", ErrorMessage = "Password and Confirm Password do not match.")]

	public string ConfirmPassword { get; set; }
	[Required(ErrorMessage = "Email cannot be blank.")]
	[EmailAddress(ErrorMessage = "Invalid Email.")]
	
	public string Email { get; set; }
	 public string Mobile { get; set; }
	 public DateTime? DateOfBirth { get; set; }	
	
	public string Address { get; set; }

}
}
