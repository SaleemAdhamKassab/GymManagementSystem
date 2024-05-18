using GMS.Mapper;
using GMS_BusinessLogic;
using GMS_BusinessLogic.Categories;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Controllers
{
	public class PurchasesController : Controller
	{
		private readonly Order _orderRepo = new();

		public IActionResult Index(string categoryName)
		{
			return View();
		}

		// Add
		public IActionResult add() => View(new Order());

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult add(IFormCollection purchaseInvoiceForm)
		{
			List<(string, string)> fields = [];
			List<(int, decimal, int)> orderProducts = [];
			Order order = new();

			//1) convert form to list
			foreach (var item in Request.Form)
				fields.Add((item.Key, item.Value));

			//2) fill order
			order.Date = DateTime.Parse(fields.ElementAt(0).Item2);
			order.SupplierId = 1;
			order.UserId = 3;

			string discountField = fields.ElementAt(fields.Count - 2).Item2;
			if (!string.IsNullOrEmpty(discountField))
				order.Discount = decimal.Parse(discountField);

			//3) fill orderProducts
			int x = 0;
			int productId = 0, productQuantity = 0;
			decimal productPrice = 0;
			(int, decimal, int) productOrder;

			for (int i = 0; i < fields.Count - 2; i++)
			{
				if (i > 2)
				{
					productId = int.Parse(fields.ElementAt(i).Item2);
					productPrice = int.Parse(fields.ElementAt(i + 1).Item2);
					productQuantity = int.Parse(fields.ElementAt(i + 2).Item2);
					productOrder = new(productId, productPrice, productQuantity);
					orderProducts.Add(productOrder);
					i += 2;
				}
			}

			try
			{
				int orderId = _orderRepo.add(order, orderProducts);
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
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult delete(Category category)
		{
			if (!ModelState.IsValid)
				return BadRequest("Invalid Category");

			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}