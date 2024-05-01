using GMS_BusinessLogic.Categories;
using System.Data;

namespace GMS.Mapper
{
	public class MapProfile
	{
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
	}
}
