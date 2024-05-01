using GMS_DataAccess;
using System.Data;


namespace GMS_BusinessLogic.Categories
{
	public class Category : IGmsRepo<Category>
	{
		enum enMode { addNew = 1, update = 2 }
		enMode _Mode = enMode.addNew;

		public int Id { get; set; }
		public string Name { get; set; }

		public Category()
		{
			this.Id = -1;
			this.Name = "";

			_Mode = enMode.addNew;
		}

		private Category(int id, string name)
		{
			this.Id = id;
			this.Name = name;

			_Mode = enMode.update;
		}

		public int add(Category category) => CategoryData.add(category.Name);

		public DataTable get() => CategoryData.get();

		public bool update(Category category)
		{
			if (category != null)
				return CategoryData.update(category.Id, category.Name);

			return false;
		}

		public static Category find(int id)
		{
			string name = "";

			if (CategoryData.findByID(id, ref name))
				return new Category(id, name);
			else
				return null;
		}

		public static Category find(string name)
		{
			int id = -1;

			if (CategoryData.findByName(ref id, name))
				return new Category(id, name);
			else
				return null;
		}

		public bool delete(int id) => CategoryData.delete(id);
	}
}
