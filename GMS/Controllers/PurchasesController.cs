using GMS.Mapper;
using GMS_BusinessLogic;
using GMS_BusinessLogic.Categories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GMS.Controllers
{
	public class PurchasesController : Controller
	{
		private readonly Category _categoryRepo = new();
		private readonly Product _productRepo = new();

		public IActionResult Index(string categoryName)
		{
			List<Category> categories = MapProfile.dtToCategories(_categoryRepo.get(categoryName));
			return View(categories);
		}

		// Add
		public IActionResult add() => View(new Order());

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult add(IFormCollection purchaseInvoiceForm)
		{

			List<(string, string)> fields = [];

			foreach (var item in Request.Form)
			{
				fields.Add((item.Key, item.Value));
			}

			try
			{

				return RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		//Edit
		public IActionResult edit(int id)
		{
			Category category = Category.find(id);
			if (category is null)
				return NotFound($"Invalid Category Id: {id}");

			return View(category);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult edit(Category category)
		{
			if (category is null)
				return NotFound($"Empty Category");

			Category categoryToUpdate = Category.find(category.Id);

			if (Category.find(category.Name).Name.Trim().ToLower() == category.Name.Trim().ToLower())
				return BadRequest($"The Category with name {category.Name} already exist");

			categoryToUpdate.Name = category.Name;

			try
			{
				_categoryRepo.update(categoryToUpdate);
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
			Category category = Category.find(id);

			if (category is null)
				return NotFound($"Invalid Category Id: {id}");

			return View(category);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult delete(Category category)
		{
			if (!ModelState.IsValid)
				return BadRequest("Invalid Category");

			try
			{
				_categoryRepo.delete(category.Id);
				return RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}