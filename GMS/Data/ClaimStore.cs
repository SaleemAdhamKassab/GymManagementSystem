﻿using System.Security.Claims;

namespace GMS.Data
{
	public static class ClaimStore
	{
		public static List<Claim> calimsList =
			[
			new Claim ("Create","Create"),
			new Claim ("Edit","Edit"),
			new Claim ("Delete","Delete"),
			];
	}
}
