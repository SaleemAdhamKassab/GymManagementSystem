using GMS.Mapper;
using GMS_BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

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
			Product productToCheck = Product.find(product.Name.Trim().ToLower());

			if (productToCheck is not null)
				return BadRequest($"The Product With Name {product.Name} already exist");
			try
			{
				int createdId = _productRepo.add(product);
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
			Product product = Product.find(id);
			if (product is null)
				return NotFound($"Invalid Product Id: {id}");

			return View(product);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult edit(Product product)
		{
			if (product is null)
				return NotFound($"Empty Product");

			Product productToCheck = Product.find(product.Name.Trim().ToLower());

			if (productToCheck is not null && productToCheck.Id != product.Id)
				return BadRequest($"The Product with name {product.Name} already exist");

			Product productToUpdate = Product.find(product.Id);
			productToUpdate.Name = product.Name;
			productToUpdate.Quantity = product.Quantity;

			try
			{
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
			if (product.Id == 0)
				return BadRequest("Invalid Product Id");

			try
			{
				_productRepo.delete(product.Id);
				return RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}