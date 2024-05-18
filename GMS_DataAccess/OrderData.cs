namespace GMS_DataAccess
{
	public class OrderData
	{
		public static int add(DateTime date, int supplierId, int userId, decimal? discount, List<(int, decimal, int)> orderProducts)
		{
			//1) insert into Orders
			int orderId = CRUD.add($"INSERT INTO Orders (Date, SupplierId, UserId) VALUES ('{date}', '{supplierId}', '{userId}');SELECT SCOPE_IDENTITY();");

			string query = string.Empty;
			int productId = 0, productQuantity = 0;
			decimal productPrice = 0, orderTotalAmount = 0;

			//productQuantities -> productId - Quantity
			List<(int, int)> productQuantities = [];


			for (int i = 0; i < orderProducts.Count; i++)
			{
				productId = orderProducts.ElementAt(i).Item1;
				productPrice = orderProducts.ElementAt(i).Item2;
				productQuantity = orderProducts.ElementAt(i).Item3;

				productQuantities.Add(new(productId, productQuantity));

				//2) insert into OrderProducts
				query = $"INSERT INTO OrderProducts (ProductId,Price,Quantity, OrderId) VALUES ({productId}, {productPrice}, {productQuantity}, {orderId});SELECT SCOPE_IDENTITY();";
				orderTotalAmount += productPrice * productQuantity;
				CRUD.add(query);
			}

			//3) Update Orders
			query = $"UPDATE Orders SET TotalAmount = {orderTotalAmount}, Discount = '{discount}' where id = {orderId}";
			CRUD.executeNonQuery(query);

			//4) Update Product Quantity
			for (int i = 0; i < productQuantities.Count; i++)
			{
				query = $"UPDATE Products SET Quantity = Quantity + {productQuantities[i].Item2} where id = {productQuantities[i].Item1}";
				CRUD.executeNonQuery(query);
			}

			return orderId;
		}

		public static bool getOrderDataById(int Id, ref DateTime date, ref int userId, ref int supplierId, ref decimal? totalAmount, ref decimal? discount)
		{
			bool isFound = true;

			SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

			string query = "SELECT * FROM Orders WHERE Id = @Id";

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@Id", Id);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					isFound = true;

					date = (DateTime)reader["Date"];
					userId = (int)reader["userId"];
					supplierId = (int)reader["SupplierID"];
					if (reader["TotalAmount"] != DBNull.Value)
						totalAmount = (decimal)reader["TotalAmount"];
					else
						totalAmount = null;
					if (reader["Discount"] != DBNull.Value)
						discount = (decimal)reader["Discount"];
					else
						discount = null;
				}
				else { isFound = false; }

				reader.Close();
			}
			catch (Exception ex)
			{
				isFound = false;
				ex = new Exception(ex.Message);
			}
			finally
			{
				connection.Close();
			}

			return isFound;
		}
	}
}
