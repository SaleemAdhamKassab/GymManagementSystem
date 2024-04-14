using GMS_DataAccess;
using System.Data;

namespace GMS_BusinessLogic
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }


		public void add(string name) => CategoryData.add(name);
		public DataTable get() => CategoryData.get();
	}
}