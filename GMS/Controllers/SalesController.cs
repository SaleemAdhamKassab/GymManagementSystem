using GMS.Mapper;
using GMS.ViewModels;
using GMS_BusinessLogic;
using GMS_BusinessLogic.Categories;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Controllers
{
	public class SalesController : Controller
	{
		private readonly SalesOrder _salesRepo = new();

		public IActionResult Index(string searchString)
		{
			List<SalesIndexViewModel> orders = MapProfile.dtToSalesDetails(_salesRepo.get(searchString));
			return View(orders);
		}

		public IActionResult details(int orderId)
		{
			//List<OrderDetailsViewModel> orderDetails = MapProfile.dtToOrderDetails(_salesRepo.getOrderDetails(orderId));
			//return View(orderDetails);
			return View();
		}

		// Add
		public IActionResult add() => View(new AddClientSaleOrderViewModel());

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult add(IFormCollection purchaseInvoiceForm)
		{
			return View();
		}

		//Delete
		public IActionResult delete(int orderId)
		{
			Order order = Order.find(orderId);
			return View(order);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult delete(Order order)
		{
			try
			{
				_salesRepo.delete(order.Id);
				return RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}