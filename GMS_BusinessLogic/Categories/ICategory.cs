using System.Data;

namespace GMS_BusinessLogic.Categories
{
	internal interface ICategory
	{
		public void add(string name);
		public DataTable get();
	}
}
