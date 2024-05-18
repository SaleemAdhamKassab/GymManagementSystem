using GMS.ViewModels;
using GMS_BusinessLogic;
using GMS_BusinessLogic.Categories;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.Data;

namespace GMS.Mapper
{
	public class MapProfile
	{
		///////////////////////////// Category /////////////////////////////
		public static List<Category> dtToCategories(DataTable categoriesDataTable)
		{
			List<Category> categories = [];

			foreach (DataRow dataRow in categoriesDataTable.Rows)
			{
				Category category = new()
				{
					Id = int.Parse(dataRow["Id"].ToString()),
					Name = dataRow["Name"].ToString()
				};

				categories.Add(category);
			}

			return categories;
		}

		///////////////////////////// Product /////////////////////////////
		public static List<Product> dtToProducts(DataTable productsDataTable)
		{
			List<Product> products = [];
			foreach (DataRow dataRow in productsDataTable.Rows)
			{
				Product product = new()
				{
					Id = int.Parse(dataRow["Id"].ToString()),
					Name = dataRow["Name"].ToString(),
					Quantity = int.Parse(dataRow["Quantity"].ToString()),
					CategoryId = int.Parse(dataRow["CategoryId"].ToString()),
					Category = Category.find(int.Parse(dataRow["CategoryId"].ToString()))
				};
				products.Add(product);
			}

			return products;
		}
		public static Product product(Product productToUpdate, Product product)
		{
			productToUpdate.Name = product.Name;
			productToUpdate.Quantity = product.Quantity;
			productToUpdate.CategoryId = product.CategoryId;

			return productToUpdate;
		}

		///////////////////////////// User /////////////////////////////
		public static List<User> dtToUsers(DataTable usersDataTable)
		{
			List<User> users = [];

			foreach (DataRow dataRow in usersDataTable.Rows)
			{
				User user = new()
				{
					Id = int.Parse(dataRow["Id"].ToString()),
					UserName = dataRow["UserName"].ToString(),
					Password = dataRow["Password"].ToString(),
					PersonId = Convert.ToInt32(dataRow["PersonId"]),
				};

				users.Add(user);
			}

			return users;
		}

		///////////////////////////// Supplier /////////////////////////////
		public static List<Supplier> dtToSuppliers(DataTable supplierDataTable)
		{
			List<Supplier> suppliers = [];

			foreach (DataRow dataRow in supplierDataTable.Rows)
			{
				Supplier supplier = new()
				{
					Id = int.Parse(dataRow["Id"].ToString()),
					PersonId = int.Parse(dataRow["PersonId"].ToString()),
					Person = null
				};
				suppliers.Add(supplier);
			}

			return suppliers;
		}
		///////////////////////////// Orders Purchases /////////////////////////////
		public static List<OrderPurchaseViewModel> dtToOrders(DataTable ordersDataTable)
		{
			List<OrderPurchaseViewModel> orders = [];

			foreach (DataRow dataRow in ordersDataTable.Rows)
			{
				OrderPurchaseViewModel order = new()
				{
					OrderId = int.Parse(dataRow["OrderId"].ToString()),
					Date = (DateTime)dataRow["Date"],
					UserName = dataRow["UserName"].ToString(),
					Supplier = dataRow["Supplier"].ToString(),
					TotalAmount = (double)dataRow["TotalAmount"],
					Discount = (double)dataRow["Discount"]
				};

				orders.Add(order);
			}

			return orders;
		}
		public static List<OrderDetailsViewModel> dtToOrderDetails(DataTable orderDetailsDataTable)
		{
			List<OrderDetailsViewModel> orderDetails = [];

			foreach (DataRow dataRow in orderDetailsDataTable.Rows)
			{
				OrderDetailsViewModel order = new()
				{
					ProductCategory = dataRow["Category Name"].ToString(),
					ProductName = dataRow["Product Name"].ToString(),
					ProductPrice = double.Parse(dataRow["Price"].ToString()),
					ProductQuantity = double.Parse(dataRow["Quantity"].ToString())
				};

				orderDetails.Add(order);
			}

			return orderDetails;
		}
	}
}