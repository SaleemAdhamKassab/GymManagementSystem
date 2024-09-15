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
		public double Price { get; set; }
		public double PriceWithProfit {  get; set; }
		public Category Category { get; set; }
		public string ImagePath {  get; set; }

		public Product()
		{
			this.Id = -1;
			this.Name = "";
			this.CategoryId = -1;
			this.Price = 0;
			this.PriceWithProfit = 0;
			this.Quantity = 0;
			this.ImagePath = string.Empty;

			_Mode = enMode.addNew;
		}

		private Product(int id, string name, int quantity, double price, double priceWithProfit, int categoryId, string imagePath)
		{
			this.Id = id;
			this.Name = name;
			this.Quantity = quantity;
			this.Price = price;
			this.PriceWithProfit = priceWithProfit;
			this.CategoryId = categoryId;
			this.Category = Category.find(this.CategoryId);
			this.ImagePath = imagePath;
			_Mode = enMode.update;
		}

		public static Product find(int id)
		{
			string name = "", imagePath = string.Empty;
			int categoryId = -1;
			int quantity = 0;
			double price = 0, priceWithProfit = 0;

			if (ProductData.getProductDataByID(id, ref name, ref quantity, ref price, ref priceWithProfit, ref categoryId, ref imagePath))
				return new Product(id, name, quantity, price, priceWithProfit, categoryId, imagePath);
			else
				return null;
		}

		public static Product find(string name)
		{
			int id = -1, categoryId = -1, quantity = 0;
			double price = 0, priceWithProfit = 0;
			string imagePath = string.Empty;

			if (ProductData.getProductDataByName(ref id, name, ref quantity, ref price, ref priceWithProfit, ref categoryId, ref imagePath))
				return new Product(id, name, quantity, price, priceWithProfit, categoryId, imagePath);
			else
				return null;
		}

		public int add(Product product) => this.Id = ProductData.add(product.Name, product.Quantity, product.Price, product.PriceWithProfit, product.CategoryId, product.ImagePath);
		public DataTable get(string searchString) => ProductData.get(searchString);
		public static DataTable get() => ProductData.get();
		public DataTable getProductsByItem(int categryId) => ProductData.getProductsByCategory(categryId);
		public bool update(Product product) => ProductData.update(product.Id, product.Name, product.Quantity, product.Price, product.PriceWithProfit, product.CategoryId, product.ImagePath);
		public bool delete(int id) => ProductData.delete(id);
	}
}