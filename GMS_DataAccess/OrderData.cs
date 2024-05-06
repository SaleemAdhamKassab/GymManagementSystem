using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
	public class OrderData
	{
		public static int add(DateTime date, int supplierId, int userId, decimal? discount, List<(int, decimal, int)> orderProducts)
		{
			//1) insert into Orders
			int orderId = CRUD.add($"INSERT INTO Orders (Date, SupplierId, UserId) VALUES ('{date}', '{supplierId}', '{userId}')");

			string query = string.Empty;
			int productId = 0, productQuantity = 0;
			decimal productPrice = 0, orderTotalAmount = 0;

			for (int i = 0; i < orderProducts.Count; i++)
			{
				productId = orderProducts.ElementAt(i).Item1;
				productPrice = orderProducts.ElementAt(i).Item2;
				productQuantity = orderProducts.ElementAt(i).Item3;

				//2) insert into OrderProducts
				query = $"INSERT INTO OrderProducts (ProductID,Price,Quantity) VALUES ({productId}, {productPrice}, {productQuantity}, {orderId}) ";
				orderTotalAmount += productPrice * productQuantity;
				CRUD.add(query);
			}

			//2) Update Orders
			query = $"UPDATE Orders SET TotalAmount = {orderTotalAmount}, Discount = {discount} where id = {orderId}";
			CRUD.executeNonQuery(query);

			////2) Update Product Quantity
			//query = $"UPDATE Products SET Quantity = {-1} where id = ";
			//CRUD.executeNonQuery(query);

			return 0;
		}
	}
}
