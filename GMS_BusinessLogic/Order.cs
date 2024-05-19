using System.Data;
using GMS_DataAccess;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GMS_BusinessLogic
{
	public class Order
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public double? TotalAmount { get; set; }
		public double? Discount { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public int SupplierId { get; set; }
		public Supplier Supplier { get; set; }
		public List<OrderProduct> OrderProducts { get; set; }

		public Order() { }
		private Order(int id, DateTime date, double? totalAmount, double? discount, int userId, int supplierId)
		{
			Id = id;
			Date = date;
			TotalAmount = totalAmount;
			Discount = discount;
			UserId = userId;
			SupplierId = supplierId;
		}



		public DataTable get(string searchString) => OrderData.getOrders(searchString);
		public DataTable getOrderDetails(int orderId) => OrderData.getOrderDetails(orderId);
		public int add(Order order, List<(int, decimal, int)> orderProducts) => OrderData.add(order.Date, order.SupplierId, order.UserId, order.Discount, orderProducts);
		public static Order find(int Id)
		{
			DateTime date = DateTime.Now;
			int userId = -1, supplierId = -1;
			double? totalAmount = 0, discount = 0;

			if (OrderData.getOrderDataById(Id, ref date, ref userId, ref supplierId, ref totalAmount, ref discount))
			{
				return new Order(Id, date, totalAmount, discount, userId, supplierId);
			}
			else
				return null;
		}
		public void delete(int orderId) => OrderData.delete(orderId);
	}
}