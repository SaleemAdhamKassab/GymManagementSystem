using System.Data;

namespace GMS_DataAccess
{
	public class CategoryData
	{
		public static int add(string name) => CRUD.add($"insert into Categories (name) values ('{name}'); SELECT SCOPE_IdENTITY();");
		public static DataTable get() => CRUD.getUsingDateTable("select * from categories order by name");
	}
}
