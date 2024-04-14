using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GMS.Models
{
	public class ApplicationUser : IdentityUser
	{
		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		public DateTime AddedOn { get; set; }
	}
}
