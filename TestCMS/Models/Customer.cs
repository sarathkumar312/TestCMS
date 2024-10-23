using System.ComponentModel.DataAnnotations;


namespace TestCMS.Models
{
	public class Customer
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(50)]
		public string FirstName { get; set; }

		[Required]
		[MaxLength(50)]
		public string LastName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }
	}
}
