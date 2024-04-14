using GMS_DataAccess;
using System.Data;

namespace GMS_BusinessLogic.Categories
{
    public class Category:ICategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

		public void add(string name) => CategoryData.add(name);
		public DataTable get()=>CategoryData.get();
	}
}