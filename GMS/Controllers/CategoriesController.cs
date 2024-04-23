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


		// Add
		public async Task<IActionResult> add() => View(new Category());

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> add(string name)
		{
			Category categoryToChcek = Category.find(name);

			if (categoryToChcek is not null)
				return BadRequest($"The Category With Name {name} already exist");

			Category category = new()
			{
				Name = name
			};

			int createdId = _category.add(category);

			if (createdId > 0)
				return RedirectToAction(nameof(Index));
			else
				return BadRequest($"Error in Adding Category: {name}");
		}

	}
}