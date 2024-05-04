using GMS_BusinessLogic;
using GMS_BusinessLogic.Categories;
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
					CategoryId = int.Parse(dataRow["CategoryId"].ToString())
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
	}
}
