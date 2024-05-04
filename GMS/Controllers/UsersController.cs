using GMS.Mapper;
using GMS_BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Controllers
{
	public class UsersController : Controller
	{
		private readonly User _UserRepo = new();

		public IActionResult Index(string UserName)
		{
			List<User> Users = MapProfile.dtToUsers(_UserRepo.get(UserName));
			return View(Users);
		}

		// Add
		public IActionResult add() => View(new User());

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult add(User user)
		{
			int createdId = _UserRepo.add(user);
			if (createdId > 0)
				return RedirectToAction(nameof(Index));
			else
				return BadRequest($"Error in Adding User: {user.UserName}");
		}

		//Edit
		public IActionResult edit(int id)
		{
			User user = GMS_BusinessLogic.User.find(id);
			if (User is null)
				return NotFound($"Invalid User Id: {id}");

			return View(User);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult edit(User user)
		{
			if (user is null)
				return NotFound($"Empty User");

			User userToUpdate = GMS_BusinessLogic.User.find(user.Id);

			try
			{
				//userToUpdate = MapProfile.User(UserToUpdate, User);
				_UserRepo.update(userToUpdate);

				return RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		//Delete
		public IActionResult delete(int id)
		{
			User User = User.find(id);
			if (User is null)
				return NotFound($"Invalid User Id: {id}");

			return View(User);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Delete(User user)
		{
			if (!ModelState.IsValid)
				return BadRequest("Invalid User");

			_UserRepo.delete(user.Id);
			return RedirectToAction(nameof(Index));
		}
	}
}