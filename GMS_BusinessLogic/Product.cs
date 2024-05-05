using System.Data;
using GMS_BusinessLogic.Categories;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
	public class Product : IGmsRepo<Product>
	{
		enum enMode { addNew = 1, update = 2 }
		enMode _Mode = enMode.addNew;

		public int Id { get; set; }
		public string Name { get; set; }
		public int Quantity { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }

		public Product()
		{
			this.Id = -1;
			this.Name = "";
			this.CategoryId = -1;
			this.Quantity = 0;

			_Mode = enMode.addNew;
		}

		private Product(int id, string name, int quantity, int categoryId)
		{
			this.Id = id;
			this.Name = name;
			this.Quantity = quantity;
			this.CategoryId = categoryId;
			this.Category = Category.find(this.CategoryId);
			_Mode = enMode.update;
		}

		public static Product find(int id)
		{
			string name = "";
			int categoryId = -1;
			int quantity = 0;

			if (ProductData.getProductDataByID(id, ref name, ref quantity, ref categoryId))
				return new Product(id, name, quantity, categoryId);
			else
				return null;
		}

		public static Product find(string name)
		{
			int id = -1, categoryId = -1, quantity = 0;

			if (ProductData.getProductDataByName(ref id, name, ref quantity, ref categoryId))
				return new Product(id, name, quantity, categoryId);
			else
				return null;
		}

		public int add(Product product) => this.Id = ProductData.add(product.Name, product.Quantity, product.CategoryId);
		public DataTable get(string searchString) => ProductData.get(searchString);

		public bool update(Product product) => ProductData.update(product.Id, product.Name, product.Quantity, product.CategoryId);
		public bool delete(int id) => ProductData.delete(id);
	}
}