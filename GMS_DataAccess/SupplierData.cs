using System.Data;

namespace GMS_DataAccess
{
	public class SupplierData
	{
		public static DataTable get() => CRUD.getUsingDateTable($"SELECT *  FROM Suppliers  s join Persons p on s.personId= p.id order by p.FirstName;");
	}
}
