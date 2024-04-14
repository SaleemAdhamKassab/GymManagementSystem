using Microsoft.AspNetCore.Authorization;

namespace GMS.Authorize
{
	public class AdminWithMore1000DaysRequirement : IAuthorizationRequirement
	{
		public int Days { get; set; } = 1000;
	}
}
