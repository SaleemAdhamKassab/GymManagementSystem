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

		public Order()
		{
			this.Id = -1;
			this.Date = DateTime.Now;
			this.TotalAmount = 0;
			this.Discount = 0;
			this.UserId = -1;
			this.SupplierId = -1;
		}

		private Order(int id, DateTime date, decimal? totalAmount, decimal? discount, int userId, int supplierId)
		{
			this.Id = id;
			this.Date = date;
			this.TotalAmount = totalAmount;
			this.Discount = discount;
			this.UserId = userId;
			this.User = User.find(this.UserId);
			this.SupplierId = supplierId;
			this.Supplier = Supplier.find(this.SupplierId);
		}

		public DataTable get(string searchString)
		{
			throw new NotImplementedException();
		}
		public int add(Order order, List<(int, decimal, int)> orderProducts) => OrderData.add(order.Date, order.SupplierId, order.UserId, order.Discount, orderProducts);
		public int add(Order order) => throw new NotImplementedException();

		public static Order find(int Id)
		{
			DateTime date = DateTime.Now;
			int userId = -1, supplierId = -1;
			decimal? totalAmount = 0, discount = 0;

			if (OrderData.getOrderDataById(Id, ref date, ref userId, ref supplierId, ref totalAmount, ref discount))
			{
				return new Order(Id, date, totalAmount, discount, userId, supplierId);
			}
			else
				return null;
		}

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