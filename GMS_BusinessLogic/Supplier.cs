using GMS_DataAccess;
using System.Data;

namespace GMS_BusinessLogic
{
	public class Supplier
	{
		public int Id { get; set; }
		public int PersonId { get; set; }
		public Person Person { get; set; }

		public static DataTable get() => SupplierData.get();
	}
}
