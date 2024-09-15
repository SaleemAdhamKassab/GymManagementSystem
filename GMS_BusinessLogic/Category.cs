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
		public bool IsForClient {  get; set; }

		public Category()
		{
			this.Id = -1;
			this.Name = "";
			this.IsForClient = false;

			_Mode = enMode.addNew;
		}

		private Category(int id, string name, bool isForClient)
		{
			this.Id = id;
			this.Name = name;
			IsForClient = isForClient;

			_Mode = enMode.update;
		}

		public int add(Category category) => CategoryData.add(category.Name, category.IsForClient);

		public DataTable get(string searchString) => CategoryData.get(searchString);

		public DataTable getClientCategoriesInfo()
		=> CategoryData.getClientCategoriesInfo();

		public bool update(Category category)
		{
			if (category != null)
				return CategoryData.update(category.Id, category.Name, category.IsForClient);

			return false;
		}

		public static Category find(int id)
		{
			string name = "";
			bool isForClient = false;

			if (CategoryData.findByID(id, ref name, ref isForClient))
				return new Category(id, name, isForClient);
			else
				return null;
		}

		public static Category find(string name)
		{
			int id = -1;
			bool isForClient = false;

			if (CategoryData.findByName(ref id, name, ref isForClient))
				return new Category(id, name, isForClient);
			else
				return null;
		}

		public bool delete(int id) => CategoryData.delete(id);
	}
}
