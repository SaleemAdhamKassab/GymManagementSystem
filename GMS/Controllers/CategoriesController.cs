using GMS_BusinessLogic.Categories;
using GMS_DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace GMS.Controllers
{
    public class CategoriesController : Controller
	{
		private readonly Category _category = new();

		public IActionResult Index()
		{
			DataTable categoriesDataTable = _category.get();

			List<Category> categories = [];

			foreach (DataRow dataRow in categoriesDataTable.Rows)
			{
				Category category = new()
				{
					Id = int.Parse(dataRow["Id"].ToString()),
					Name = dataRow["Name"].ToString()
				};

				categories.Add(category);
			}

			return View(categories);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult add(string name)
		{
			//if (_roleManager.RoleExistsAsync(roleName))
			//	return BadRequest($"The Role {roleName} is already Exists");

			//IdentityRole newIdentityRole = new()
			//{
			//	Name = roleName,
			//	NormalizedName = roleName.ToUpper()
			//};

			//await _roleManager.CreateAsync(newIdentityRole);

			_category.add(name);

			return RedirectToAction(nameof(Index));
		}

	}
}