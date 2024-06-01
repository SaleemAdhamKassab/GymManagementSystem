using GMS_DataAccess;
using System.Data;

namespace GMS_BusinessLogic
{
	public class OrderProduct
	{
		public int Id { get; set; }
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }

		public Product ProductInfo;

		private OrderProduct(int  id, int orderId, int productId, decimal price, int quantity)
		{
			Id = id;
			OrderId = orderId;
			ProductId = productId;
			ProductInfo = Product.find(productId);
			Price = price;
			Quantity = quantity;
		}

		public static OrderProduct find(int id)
		{
			int orderId = -1, productId = -1, quantity = 0;
			decimal price = 0;

			if (OrderProductData.GetOrderProductDataByID(id, ref quantity, ref price, ref productId, ref orderId))
				return new OrderProduct(id, orderId, productId, price, quantity);
			else return null;
        }

        public static OrderProduct findByOrderID(int orderId)
        {
            int Id = -1, productId = -1, quantity = 0;
            decimal price = 0;

            if (OrderProductData.GetOrderProductDataByOrderID(orderId, ref Id, ref quantity, ref price, ref productId))
                return new OrderProduct(Id, orderId, productId, price, quantity);
            else return null;
        }

		public static DataTable getAllOrderProductDetails(int orderId) => OrderProductData.getAllOrderProductDetails(orderId);
    }
}
