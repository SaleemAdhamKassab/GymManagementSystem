using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
	public class Order : IGmsRepo<Order>
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public decimal? TotalAmount { get; set; }
		public decimal? Discount { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public int SupplierId { get; set; }
		public Supplier Supplier { get; set; }
		public List<OrderProduct> OrderProducts { get; set; }


		public DataTable get(string searchString)
		{
			throw new NotImplementedException();
		}
		public int add(Order order, List<(int, decimal, int)> orderProducts) => OrderData.add(order.Date, order.SupplierId, order.UserId, order.Discount, orderProducts);
		public int add(Order order) => throw new NotImplementedException();

		public bool update(Order order)
		{
			throw new NotImplementedException();
		}
		public bool delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}