using GMS.Mapper;
using GMS_BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Controllers
{
	public class ProductsController : Controller
	{
		private readonly Product _productRepo = new();

		public IActionResult Index(string productName)
		{
			List<Product> products = MapProfile.dtToProducts(_productRepo.get(productName));
			return View(products);
		}

		// Add
		public IActionResult add() => View(new Product());

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult add(Product product)
		{
			Product productToCheck = Product.find(product.Name);

			if (productToCheck is not null)
				return BadRequest($"The Product With Name {product.Name} already exist");

			int createdId = _productRepo.add(product);

			if (createdId > 0)
				return RedirectToAction(nameof(Index));
			else
				return BadRequest($"Error in Adding Product: {product.Name}");
		}

		//Edit
		public IActionResult edit(int id)
		{
			Product Product = Product.find(id);
			if (Product is null)
				return NotFound($"Invalid Product Id: {id}");

			return View(Product);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult edit(Product product)
		{
			if (product is null)
				return NotFound($"Empty Product");

			Product productToUpdate = Product.find(product.Id);

			try
			{
				productToUpdate = MapProfile.product(productToUpdate, product);
				_productRepo.update(productToUpdate);

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
			Product product = Product.find(id);

			if (product is null)
				return NotFound($"Invalid Product Id: {id}");

			return View(product);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Delete(Product product)
		{
			if (!ModelState.IsValid)
				return BadRequest("Invalid Product");

			_productRepo.delete(product.Id);
			return RedirectToAction(nameof(Index));
		}
	}
}